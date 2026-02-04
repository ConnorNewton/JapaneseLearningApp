using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseLearningApp
{
    public class Settings
    {
        public bool enableTTS { get; set; }
        public VoiceGender genderTTS { get; set; }
        public int volumeTTS { get; set; }

        public Settings(bool enableTTS, VoiceGender genderTTs, int volumeTTS) 
        {
            this.enableTTS = enableTTS;
            this.volumeTTS = volumeTTS;
            this.genderTTS = genderTTs;
        }
    }
}
