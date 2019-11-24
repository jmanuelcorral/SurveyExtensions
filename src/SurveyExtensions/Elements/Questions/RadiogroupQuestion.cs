namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.QuestionElements;
    using System.Collections.Generic;

    public class RadiogroupQuestion : SurveyQuestion
    {

        public RadiogroupQuestion()
        {
            Type = "radiogroup";
        }

        public string ChoicesOrder { get; set; }
        public int ColCount { get; set; }
        public bool HasOther { get; set; }
        public string OtherText { get; set; }

        public IList<Choice> Choices { get; set; } = new List<Choice>();

    }
}