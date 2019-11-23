namespace SurveyExtensions.Elements.Questions
{
    using System;

    public abstract class SurveyQuestion : SurveyItem
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Visible { get; set; } = true;
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;

    }
}