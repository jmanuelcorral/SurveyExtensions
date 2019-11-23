namespace SurveyExtensions.Elements.Questions
{
    public class SingleInputQuestion : SurveyQuestion
    {
        public SingleInputQuestion()
        {
            Type = "text";
            InputType = "text";
        }

        public string PlaceHolder { get; set; }
        public string InputType { get; set; }
    }
}