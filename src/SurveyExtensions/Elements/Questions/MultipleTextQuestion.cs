namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.ChoiceItems;
    using System.Collections.Generic;

    public class MultipleTextQuestion : SurveyQuestion
    {
        public MultipleTextQuestion()
        {
            Type = "multipletext";
        }

        public int ColCount { get; set; } = 1;
       
        public IList<MultiTextItem> Items { get; set; } = new List<MultiTextItem>();
    }
}