namespace SurveyExtensions.Elements.Questions
{
    public class SingleInputQuestion : Question
    {
        public SingleInputQuestion()
        {
            Type = "text";
            InputType = "text";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public string PlaceHolder { get; set; }
        public string InputType { get; set; }
    }
}