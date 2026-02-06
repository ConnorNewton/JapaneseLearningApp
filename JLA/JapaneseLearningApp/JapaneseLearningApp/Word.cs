using SpacedRepetition.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseLearningApp
{
    internal class Word : IReviewItem
    {
        //Word Properties
        public string romaji { get; set; }
        public string furigana { get; set; }
        public string meaning { get; set; }
        public string word { get; set; }
        public int level { get; set; }


        //Spaced Repetition Properties

        public DifficultyRating DifficultyRating { get; set; } = DifficultyRating.Easiest; //null otherwise so maybe this is okay?????
        public DateTime ReviewDate { get; set; }
        public DateTime PreviousCorrectReview { get; set; }
        public int CorrectReviewStreak { get; set; }
    }
}
