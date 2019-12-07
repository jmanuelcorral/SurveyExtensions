namespace SurveyExtensions.Elements.Questions
{
    public class BooleanQuestion : Question
    {
        public BooleanQuestion()
        {
            Type = "boolean";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public string Label { get; set; }
        public string LabelTrue { get; set; } = "Yes";
        public string LabelFalse { get; set; } = "No";
    }
}