namespace SurveyExtensions.Elements.Questions
{
    public class CommentsQuestion : Question
    {
        public CommentsQuestion()
        {
            Type = "comment";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public string PlaceHolder { get; set; }
        public int Rows { get; set; } = 4;
    }
}