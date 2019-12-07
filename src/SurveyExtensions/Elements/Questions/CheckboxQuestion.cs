namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.QuestionElements;
    using System.Collections.Generic;

    public class CheckboxQuestion : Question
    {
        public CheckboxQuestion()
        {
            Type = "checkbox";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public string ChoicesOrder { get; set; }
        public int ColCount { get; set; }
        public IList<Choice> Choices { get; set; } = new List<Choice>();
        public bool HasOther { get; set; }
        public string OtherText { get; set; }
        public bool HasSelectAll { get; set; } = false;
        public string SelectAllText { get; set; }
        public bool HasNone { get; set; } = false;
        public string NoneText { get; set; }
    }
}