namespace SurveyExtensions.Elements.Questions
{
    public class BooleanQuestion : Question
    {
        public BooleanQuestion()
        {
            Type = "boolean";
        }

        public string Label { get; set; }
        public string LabelTrue { get; set; } = "Yes";
        public string LabelFalse { get; set; } = "No";
    }
}