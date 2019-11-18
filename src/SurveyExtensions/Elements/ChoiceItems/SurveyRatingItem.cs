namespace SurveyExtensions.Elements.ChoiceItems
{
    using System.Collections.Generic;

    public class SurveyRatingItem : SurveyPageElement
    {

        public SurveyRatingItem()
        {
            Type = "rating";
        }

        public int RateMin { get; set; } = 1;
        public int RateMax { get; set; } = 5;
        public int RateStep { get; set; } = 1;

        public IList<SurveyChoice> RateValues { get; set; } = new List<SurveyChoice>();

        public string MinRateDescription { get; set; }

        public string MaxRateDescription { get; set; }
    }
}