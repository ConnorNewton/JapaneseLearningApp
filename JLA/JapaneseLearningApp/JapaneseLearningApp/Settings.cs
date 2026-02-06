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
        public enum StudyIntensity
        {
            Light,
            Standard,
            Intesive
        }

        public bool enableTTS { get; set; }
        public VoiceGender genderTTS { get; set; }
        public int volumeTTS { get; set; }
        public bool showJapaneseWord { get; set; }
        public bool showFurigana { get; set; }
        public bool showRomaji { get; set; }
        public StudyIntensity studyIntensity { get; set; }

        public Settings(bool enableTTS, VoiceGender genderTTs, int volumeTTS, bool showRomaji, bool showJapaneseWord, bool showFurigana, StudyIntensity studyIntensity) 
        {
            this.enableTTS = enableTTS;
            this.volumeTTS = volumeTTS;
            this.genderTTS = genderTTs;
            this.showFurigana = showFurigana;
            this.showJapaneseWord = showJapaneseWord;
            this.showRomaji = showRomaji;
            this.studyIntensity = studyIntensity;
        }
    }
}
