namespace SurveyExtensions.Elements
{
    using System;

    public class SurveyPageElement : SurveyItem
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public Boolean IsRequired { get; set; } = false;
    }
}