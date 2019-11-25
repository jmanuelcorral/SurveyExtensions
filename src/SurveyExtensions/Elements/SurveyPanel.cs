namespace SurveyExtensions.Elements
{
    using System.Collections.Generic;

    public class SurveyPanel : SurveyItem
    {
        public string Type { get => "panel"; }
        public IList<SurveyItem> Elements { get; set; } = new List<SurveyItem>();
    }
}