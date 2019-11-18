namespace SurveyExtensions.Elements
{
    public class SurveyItem
    {
        public string Name { get; set; }
        public bool Visible { get; set; } = true;
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;

    }
}