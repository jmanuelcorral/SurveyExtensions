namespace SurveyExtensions.Elements
{
    public class SurveyBooleanItem : SurveyPageElement
    {
        public SurveyBooleanItem()
        {
            Type = "boolean";
        }

        public string Label { get; set; }
        public string LabelTrue { get; set; } = "Yes";
        public string LabelFalse { get; set; } = "No";
    }
}