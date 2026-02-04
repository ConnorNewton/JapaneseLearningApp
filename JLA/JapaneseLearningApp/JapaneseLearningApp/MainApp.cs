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

namespace JapaneseLearningApp
{
    public partial class MainApp : Form
    {
        private HttpClient HttpClient = new HttpClient(); //http client for getting words from api

        private StudySession<Word> studySession = null; //Current Study session containing all words user is learning

        private SpeechSynthesizer synth = new SpeechSynthesizer(); //voice synthesizer for pronunciation
        private bool useSynth = false; //bool for user to select whether or not to use synthesizer

        private int proficiencyLevel = 5; //difficulty level of the words given (N5-N1)

        private bool userFound = false; //bool to check if user already exists

        public Settings settings { get; private set; } //Settings object for storing user settings


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
                GetWords();
            }
        }

        #region Helper Methods

        private async void GetWords()
        {
            //Get all the words from the API
            var response = await HttpClient.GetAsync($"https://jlpt-vocab-api.vercel.app/api/words/all");
            string jsonResponse = await response.Content.ReadAsStringAsync();
            using JsonDocument doc = JsonDocument.Parse(jsonResponse);
            JsonElement words = doc.RootElement.GetProperty("words");

            //deserialize all words into the study session
            studySession = new StudySession<Word>(JsonSerializer.Deserialize<List<Word>>(words));

            //begin showing flashcards
            StartStudySession();
        }

        private void StartStudySession()
        {
            foreach (Word word in studySession)
            {
                if (word.level == proficiencyLevel)
                {
                    labelWord.Text = word.romaji;

                    if (settings.enableTTS)
                    {
                        synth.Speak(word.word);
                    }
                }
            }

        }

        #endregion

        #region Events

        private void labelWord_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            //Easy, Hard, etc buttons
        }

        #endregion

        #region Settings

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsDialog settingsDialog = new SettingsDialog(settings);

            if (settingsDialog.ShowDialog() == DialogResult.OK)
            {
                ApplySettings();
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
    }
}
