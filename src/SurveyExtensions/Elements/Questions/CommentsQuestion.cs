namespace SurveyExtensions.Elements.Questions
{
    public class CommentsQuestion : SurveyQuestion
    {
        public CommentsQuestion()
        {
            Type = "comment";
        }

        public string PlaceHolder { get; set; }
        public int Rows { get; set; } = 4;
    }
}