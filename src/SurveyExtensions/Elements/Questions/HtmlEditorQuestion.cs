namespace SurveyExtensions.Elements.Questions
{
    public class HtmlEditorQuestion : Question
    {
        public HtmlEditorQuestion()
        {
            Type = "html";
        }

        public bool StartWithNewLine { get; set; } = true;
        public string Html { get; set; }
    }
}