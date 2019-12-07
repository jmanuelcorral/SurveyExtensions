namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.QuestionElements;
    using System.Collections.Generic;

    public class DropdownIQuestion : Question
    {

        public DropdownIQuestion()
        {
            Type = "dropdown";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public string ChoicesOrder { get; set; }
        public IList<Choice> Choices { get; set; } = new List<Choice>();
        public bool HasOther { get; set; } = false;
        public string OtherText { get; set; }
        public string OptionCaption { get; set; }
        public int ChoicesMin { get; set; }
        public int ChoicesMax { get; set; }
        public int ChoicesStep { get; set; }
    }
}