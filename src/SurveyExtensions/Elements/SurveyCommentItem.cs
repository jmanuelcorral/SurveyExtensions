namespace SurveyExtensions.Elements
{
    public class SurveyCommentItem : SurveyPageElement
    {
        public SurveyCommentItem()
        {
            Type = "comment";
        }

        public string PlaceHolder { get; set; }
        public int Rows { get; set; } = 4;
    }
}