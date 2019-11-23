namespace SurveyExtensions.Elements.Questions
{
    public class HtmlEditorQuestion : SurveyQuestion
    {
        public HtmlEditorQuestion()
        {
            Type = "html";
        }

        public string Html { get; set; }
    }
}