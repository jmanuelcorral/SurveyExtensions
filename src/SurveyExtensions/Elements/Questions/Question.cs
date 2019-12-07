namespace SurveyExtensions.Elements.Questions
{
    using System;

    public abstract class Question : SurveyItem
    {
        public string Type { get; set; }
        public bool Visible { get; set; } = true;
    }
}