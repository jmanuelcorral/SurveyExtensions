namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.ChoiceItems;
    using System.Collections.Generic;

    public class CheckboxQuestion : SurveyQuestion
    {
        public CheckboxQuestion()
        {
            Type = "checkbox";
        }

        public string ChoicesOrder { get; set; }

        public int ColCount { get; set; }

        public IList<Choice> Choices { get; set; } = new List<Choice>();


        public string OtherText { get; set; }

        public bool HasSelectAll { get; set; } = false;
        public string SelectAllText { get; set; }

        public bool HasNone { get; set; } = false;
        public string NoneText { get; set; }
    }
}