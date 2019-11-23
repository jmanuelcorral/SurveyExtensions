namespace SurveyExtensions.Elements.Questions
{
    public class BooleanQuestion : SurveyQuestion
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