namespace SurveyExtensions.Elements.Questions
{
    public class SingleInputQuestion : Question
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