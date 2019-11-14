namespace SurveyExtensions.Elements
{
    using System.Collections.Generic;

    public class SurveyPage:SurveyItem
    {
        public string Name { get; set; }
        public IList<SurveyItem> Elements { get; set; } = new List<SurveyItem>();
    }
}