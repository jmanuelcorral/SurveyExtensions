namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.ChoiceItems;
    using System.Collections.Generic;

    public class DropdownIQuestion : SurveyQuestion
    {

        public DropdownIQuestion()
        {
            Type = "dropdown";
        }

        public string ChoicesOrder { get; set; }

        public IList<Choice> Choices { get; set; } = new List<Choice>();


        public bool HasOther { get; set; } = false;
        public string OtherText { get; set; }

        public string OptionCaption { get; set; }
    }
}