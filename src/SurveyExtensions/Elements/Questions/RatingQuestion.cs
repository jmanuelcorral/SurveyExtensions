namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.QuestionElements;
    using System.Collections.Generic;

    public class RatingQuestion : Question
    {

        public RatingQuestion()
        {
            Type = "rating";
        }

        public int RateMin { get; set; } = 1;
        public int RateMax { get; set; } = 5;
        public int RateStep { get; set; } = 1;

        public IList<Choice> RateValues { get; set; } = new List<Choice>();

        public string MinRateDescription { get; set; }

        public string MaxRateDescription { get; set; }
    }
}