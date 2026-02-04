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

namespace JapaneseLearningApp
{
    public partial class MainApp : Form
    {
        private HttpClient HttpClient = new HttpClient(); //http client for getting words from api

        private SpeechSynthesizer synth = new SpeechSynthesizer(); //voice synthesizer for pronunciation
        private bool useSynth = false; //bool for user to select whether or not to use synthesizer

        private List<Word> userWords = new List<Word>(); //list containing all words user is learning currently\
        private int userWordIndex = 0; //global index for that word

        private bool userFound = false; //bool for checking if user exists

        private int difficultyLevel = 5; //difficulty level of the words given (N5-N1)

        public Settings settings { get; private set; }


        public MainApp()
        {
            InitializeComponent();

            //initial settings
            settings = new Settings(false, VoiceGender.Male, 100);
            ApplySettings();

            if (userFound)
            {
                //LOAD DATA
            }
            else
            {
                //start new user with 20 words to learn
                GetNewWords(20);
            }
        }

        #region Helper Methods

        private async void GetNewWords(int count)
        {
            //Get the words from the API
            var response = await HttpClient.GetAsync($"https://jlpt-vocab-api.vercel.app/api/words?level={difficultyLevel}&limit={count}&offset={userWords.Count}");
            string jsonResponse = await response.Content.ReadAsStringAsync();
            using JsonDocument doc = JsonDocument.Parse(jsonResponse);
            JsonElement words = doc.RootElement.GetProperty("words");

            //deserialize into a word list
            List<Word> wordsList = JsonSerializer.Deserialize<List<Word>>(words);

            //add the words to the user words
            userWords.AddRange(wordsList);

            //begin showing flashcards
            ShowFlashCard();
        }

        private void ShowFlashCard()
        {
            //clear the screem amd reenable clicking
            labelWord.Text = "";
            labelWord.Enabled = true;

            //display the words until no words are left in the list
            if (userWordIndex > userWords.Count - 1)
            {
                labelWord.Text = "Learning Complete\nCome back tomorrow";
            }
            else
            {
                labelWord.Text = userWords[userWordIndex].romaji;
                synth.Speak(userWords[userWordIndex].word);
            }

        }

        private void ApplySettings()
        {
            if (settings.enableTTS)
            {
                //set voice to japanese (THIS WILL NOT REMAIN WHEN PEOPLE PRESS INSTALL NEED TO ENABLE SETTING)
                synth.SelectVoiceByHints(settings.genderTTS, VoiceAge.NotSet, 0, new CultureInfo("ja-JP"));
                synth.Volume = settings.volumeTTS;
            }
        }

        #endregion

        #region Events

        private void labelWord_Click(object sender, EventArgs e)
        {
            //show meaning and disable clicking
            labelWord.Text += $"\n{userWords[userWordIndex].meaning}";
            labelWord.Enabled = false;
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            SM2


            ++userWordIndex;
            ShowFlashCard();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsDialog settingsDialog = new SettingsDialog(settings);

            if(settingsDialog.ShowDialog() == DialogResult.OK)
            {
                ApplySettings();
            }
        }

        #endregion
    }
}
