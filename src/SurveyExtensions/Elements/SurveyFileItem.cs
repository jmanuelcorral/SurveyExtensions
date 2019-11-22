namespace SurveyExtensions.Elements
{
    public class SurveyFileItem : SurveyPageElement
    {
        public SurveyFileItem()
        {
            Type = "file";
        }

        public int MaxSize { get; set; } = 0;
    }
}