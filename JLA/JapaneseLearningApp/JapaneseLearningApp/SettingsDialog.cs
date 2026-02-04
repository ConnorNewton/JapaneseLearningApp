using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Speech.Synthesis.TtsEngine;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseLearningApp
{
    public partial class SettingsDialog : Form
    {
        private SpeechSynthesizer testSynth = new SpeechSynthesizer();
        private Settings settings;

        public SettingsDialog(Settings settings)
        {
            InitializeComponent();

            this.settings = settings;

            // Initialize UI from the existing settings
            checkBoxEnableTTS.Checked = settings.enableTTS;
            comboBoxVoiceGender.SelectedIndex = settings.genderTTS == VoiceGender.Male ? 0 : 1;
            trackBarVol.Value = settings.volumeTTS;
            labelVol.Text = trackBarVol.Value.ToString();
        }

        #region Open/Close Buttons
        private void buttonDone_Click(object sender, EventArgs e)
        {
            //OTHER SETTINGS CAN GO HERE TTS IN EVENTS FOR THE SAKE OF TEST BUTTON


            //Close Dialog
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //close without applying settings
            Close();
        }

        #endregion

        #region TTS

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //change volume label on the settings dialog
            settings.volumeTTS = trackBarVol.Value;
            labelVol.Text = trackBarVol.Value.ToString();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            //set with current settings
            testSynth.SelectVoiceByHints(settings.genderTTS, VoiceAge.Adult, 0, new CultureInfo("ja-JP"));
            testSynth.Volume = settings.volumeTTS;

            if (settings.enableTTS)
            {
                //Hear the settings
                testSynth.SpeakAsync("試し");
            }
        }

        private void comboBoxVoiceGender_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //set voice to selected voice
            settings.genderTTS = comboBoxVoiceGender.SelectedIndex == 0 ? VoiceGender.Male : VoiceGender.Female;
        }
        private void checkBoxEnableTTS_Click(object sender, EventArgs e)
        {
            //enable tts for reading flashcards
            settings.enableTTS = checkBoxEnableTTS.Checked;

            //stop showing if user selects do not show again
            if (TTSWarning && checkBoxEnableTTS.Checked)
            {
                TTSWarning tTSWarning = new TTSWarning();

                if (tTSWarning.ShowDialog() == DialogResult.OK)
                {
                    Process.Start(new ProcessStartInfo("ms-settings:regionlanguage") { UseShellExecute = true });
                }
            }
        }

        #endregion


    }
}
