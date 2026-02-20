using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.DirectoryServices;
using System.Speech.Synthesis;
using System.Globalization;
using SpacedRepetition.Net;
using SpacedRepetition.Net.ReviewStrategies;
using static System.Collections.Specialized.BitVector32;
using System.Runtime.CompilerServices;
using System.Drawing.Design;
using System.Speech.Recognition;

namespace JapaneseLearningApp
{
    public partial class MainApp : Form
    {
        //API
        private HttpClient HttpClient = new HttpClient(); //http client for getting words from api

        //Spaced Repetition
        private StudySession<Word> studySession = null; //Current Study session containing all words user is learning
        private IEnumerator<Word> enumerator = null; //enumerator to move to the next word in the study session
        private List<Word> allWords = new List<Word>(); //all words from the api
        private Word currentWord = null; //current word the user is reviewing in the study session
        private bool allowFlashCardClick = true; //disables the user from interacting with the flashcard

        //Synthesizer
        private SpeechSynthesizer synth = new SpeechSynthesizer(); //voice synthesizer for pronunciation

        //Speech Recognition
        private SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine(new CultureInfo("ja-JP"));
        private Random rand = new Random();

        //Settings
        public Settings settings { get; private set; } //Settings object for storing user settings


        public MainApp()
        {
            InitializeComponent();

            //Load user data if it exists otherwise start new
            LoadFile();
        }

        #region Helper Methods

        private async void GetWordsFromAPI()
        {

            try
            {
                //Get all the words from the API
                var response = await HttpClient.GetAsync($"https://jlpt-vocab-api.vercel.app/api/words/all");
                string jsonResponse = await response.Content.ReadAsStringAsync();
                allWords = JsonSerializer.Deserialize<List<Word>>(jsonResponse);

                //start studying
                StartStudySession();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting words from API: {ex.Message}");
            }

        }

        private async void ShowNextFlashcard()
        {
            //check if there are more cards to learn
            if (enumerator.MoveNext())
            {
                //returned true so there is still cards to study
                currentWord = enumerator.Current;
            }
            else
            {
                //returned false so there are no more cards review is complete
                labelWord.Text = "Review Complete!\nNo more flashcards for today! Come back tomorrow!";
                allowFlashCardClick = false;
                buttonIncorrect.Enabled = false;
                buttonHesitant.Enabled = false;
                buttonPerfect.Enabled = false;
                SaveFile();
                return;
            }

            //clear the label
            labelWord.Text = "";

            //show the romaji of the word
            if (settings.showFurigana)
            {
                labelWord.Text = currentWord.furigana;
            }

            if (settings.showJapaneseWord)
            {
                labelWord.Text += $"\n{currentWord.word}";
            }

            if (settings.showRomaji)
            {
                labelWord.Text += $"\n{currentWord.romaji}";
            }

            //add instructions
            labelClick.Visible = true;

            //disable so the user cannot rate until the answer is showm
            buttonIncorrect.Enabled = false;
            buttonHesitant.Enabled = false;
            buttonPerfect.Enabled = false;

            //ensure ui is fully shown
            await Task.Yield();

            //TTS if enabled in settings
            if (settings.enableTTS)
            {
                synth.SpeakAsync(currentWord.word);
            }

            //Load word if Speech is enabled
            if(settings.enableVoiceRec)
            {
                LoadWordRecognition();
            }
        }
        private void StartStudySession()
        {
            //deserialize all words into the study session
            studySession = new StudySession<Word>(allWords);

            //select new cards and review cards based on user preference
            if (settings.studyIntensity == Settings.StudyIntensity.Light)
            {
                studySession.MaxNewCards = 10; //max new cards added each session
                studySession.MaxExistingCards = 20; //max cards we previously learned to show this session so total session is maxnew + max existing
            }
            else if (settings.studyIntensity == Settings.StudyIntensity.Standard)
            {
                studySession.MaxNewCards = 15;
                studySession.MaxExistingCards = 30;
            }
            else
            {
                studySession.MaxNewCards = 20;
                studySession.MaxExistingCards = 40;
            }

            //Use supermemo2 review algorithm
            studySession.ReviewStrategy = new SuperMemo2ReviewStrategy();

            //init enumerator for itterating over study session
            enumerator = studySession.GetEnumerator();

            //show the first flashcard
            ShowNextFlashcard();
        }

        private void LoadWordRecognition()
        {
            //reset recognizer
            recognizer.UnloadAllGrammars();

            //create the word to be recognized
            GrammarBuilder gb = new GrammarBuilder(currentWord.word);
            gb.Culture = new CultureInfo("ja-JP");

            //load the grammar to the recognizer to begin recognizing
            Grammar grammar = new Grammar(gb);
            recognizer.LoadGrammar(grammar);

            //reset the label
            labelSpeak.Text = "Try speaking the word";
        }

        #endregion

        #region Save/Load

        private async void LoadFile()
        {
            //load user settings
            string dataPathSettings = Path.Combine(Application.UserAppDataPath, "settings.json");
            //load user settings
            if (File.Exists(dataPathSettings))
            {
                // Load saved progress
                string json = File.ReadAllText(dataPathSettings);
                settings = JsonSerializer.Deserialize<Settings>(json);
            }
            else
            {
                //use default
                settings = new Settings(false, VoiceGender.Male, 100, true, false, false, Settings.StudyIntensity.Standard, false); //CHANGE BOOLS TO ENUMS FOR BETTER READING
            }

            //initialize the tts if it is enabled from settings
            InitTTS();



            //load user data
            string dataPathUser = Path.Combine(Application.UserAppDataPath, "user.json");
            if (File.Exists(dataPathUser))
            {
                // Load saved progress
                string json = File.ReadAllText(dataPathUser);
                allWords = JsonSerializer.Deserialize<List<Word>>(json);

                //Begin studying
                StartStudySession();
            }
            else
            {
                // First time opening then wait to fetch from API then start
                GetWordsFromAPI();
            }



            //initialize the speech rec if enabled from settings (must be down here so word exists)
            InitSpeech();

        }

        private void SaveFile()
        {
            //saves user progress
            string dataPathUser = Path.Combine(Application.UserAppDataPath, "user.json");
            string jsonUser = JsonSerializer.Serialize(allWords, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataPathUser, jsonUser);

            //saves user settings
            string dataPathSettings = Path.Combine(Application.UserAppDataPath, "settings.json");
            string jsonSettings = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(dataPathSettings, jsonSettings);

        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ensure progress is saved if user force closes the app
            SaveFile();
        }

        #endregion

        #region Events

        private void labelWord_Click(object sender, EventArgs e)
        {
            if (allowFlashCardClick)
            {
                //write the meaning of the word
                labelWord.Text += $"\n{currentWord.meaning}";

                //disable all the buttons so user cannot rate until answer is shown
                buttonIncorrect.Enabled = true;
                buttonHesitant.Enabled = true;
                buttonPerfect.Enabled = true;

                //stop user from interacting until rate button is pressed
                allowFlashCardClick = false;

                //hide hint
                labelClick.Visible = false;
            }
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            //get the tag on the button clicked
            Button button = (Button)sender;
            string rating = (string)button.Tag;

            //set the review to whatever the user selected
            Word updatedWord = new Word();
            switch (rating)
            {
                case "Incorrect":
                    updatedWord = studySession.Review(currentWord, ReviewOutcome.Incorrect);
                    break;
                case "Hesitant":
                    updatedWord = studySession.Review(currentWord, ReviewOutcome.Hesitant);
                    break;
                case "Perfect":
                    updatedWord = studySession.Review(currentWord, ReviewOutcome.Perfect);
                    break;
            }

            // copy word contents because space repetition lib makes new words causing them to be null if not copied
            updatedWord.romaji = currentWord.romaji;
            updatedWord.furigana = currentWord.furigana;
            updatedWord.meaning = currentWord.meaning;
            updatedWord.word = currentWord.word;
            updatedWord.level = currentWord.level;

            //update the current word with the new calculated data
            currentWord.ReviewDate = updatedWord.ReviewDate;
            currentWord.DifficultyRating = updatedWord.DifficultyRating;
            currentWord.CorrectReviewStreak = updatedWord.CorrectReviewStreak;
            currentWord.PreviousCorrectReview = updatedWord.PreviousCorrectReview;

            //continue reviewing
            allowFlashCardClick = true;
            ShowNextFlashcard();
        }

        private void Recognizer_SpeechRecognized(object? sender, SpeechRecognizedEventArgs e)
        {
            string spokenText = e.Result.Text;
            float confidence = e.Result.Confidence;

            if (confidence > 0.85f)
            {
                labelSpeak.Text = "Perfect!";

                //congratulations message randomized
                int randVal = rand.Next(1, 5);
                if (randVal == 1)
                    synth.SpeakAsync("いいね");
                else if (randVal == 2)
                    synth.SpeakAsync("ナイス");
                else if (randVal == 3)
                    synth.SpeakAsync("さすが");
                else
                    synth.SpeakAsync("お疲れ");

            }
            else
            {
                labelSpeak.Text = "Try again!";
                synth.Speak(currentWord.romaji);
            }
                
        }

        #endregion

        #region Settings

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsDialog settingsDialog = new SettingsDialog(settings);

            if (settingsDialog.ShowDialog() == DialogResult.OK)
            {
                InitTTS();
                InitSpeech();
            }
        }

        private void InitTTS()
        {
            if (settings.enableTTS)
            {
                //set voice to japanese (THIS WILL NOT REMAIN WHEN PEOPLE PRESS INSTALL NEED TO ENABLE SETTING)
                synth.SelectVoiceByHints(settings.genderTTS, VoiceAge.NotSet, 0, new CultureInfo("ja-JP"));
                synth.Volume = settings.volumeTTS;
            }

        }

        private void InitSpeech()
        {
            if(settings.enableVoiceRec)
            {
                //Make the default mic the one set on the users computer
                recognizer.SetInputToDefaultAudioDevice();

                labelSpeak.Visible = true;

                //init the event
                recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

                //load the current word
                LoadWordRecognition();

                //make the recognizer listen continuously
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
            else
            {
                labelSpeak.Visible = false;
            }
        }

        #endregion


    }
}
