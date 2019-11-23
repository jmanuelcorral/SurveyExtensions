namespace SurveyExtensions.Elements
{
    using System.Collections.Generic;

    public class SurveyPage : SurveyItem
    {
        public IList<SurveyItem> Elements { get; set; } = new List<SurveyItem>();
    }
}