namespace SurveyExtensions.Elements.Questions
{
    public class HtmlEditorQuestion : Question
    {
        public HtmlEditorQuestion()
        {
            Type = "html";
        }

        public string Html { get; set; }
    }
}