namespace SurveyExtensions.Elements
{
    public class SurveyHtmlEditorItem : SurveyPageElement
    {
        public SurveyHtmlEditorItem()
        {
            Type = "html";
        }

        public string Html { get; set; }
    }
}