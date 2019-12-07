namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.QuestionElements;
    using System.Collections.Generic;

    public class MultipleTextQuestion : Question
    {
        public MultipleTextQuestion()
        {
            Type = "multipletext";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public int ColCount { get; set; } = 1;
        public IList<MultiTextItem> Items { get; set; } = new List<MultiTextItem>();
    }
}