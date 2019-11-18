namespace SurveyExtensions.Elements.ChoiceItems
{
    using System.Collections.Generic;

    public class SurveyDropdownItem : SurveyPageElement
    {

        public SurveyDropdownItem()
        {
            Type = "dropdown";
        }

        public string ChoicesOrder { get; set; }

        public IList<SurveyChoice> Choices { get; set; } = new List<SurveyChoice>();


        public bool HasOther { get; set; } = false;
        public string OtherText { get; set; }

        public string OptionCaption { get; set; }
    }
}