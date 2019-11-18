namespace SurveyExtensions.Elements
{
    public class SurveyInputItem : SurveyPageElement
    {
        public SurveyInputItem()
        {
            Type = "text";
            InputType = "text";
        }

        public string PlaceHolder { get; set; }
        public string InputType { get; set; }
    }
}