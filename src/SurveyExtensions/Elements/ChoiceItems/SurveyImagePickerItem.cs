namespace SurveyExtensions.Elements.ChoiceItems
{
    using System.Collections.Generic;

    public class SurveyImagePickerItem : SurveyPageElement
    {
        public SurveyImagePickerItem()
        {
            Type = "imagepicker";
        }

        public string ChoicesOrder { get; set; }

        public int ColCount { get; set; } = 0;

        public IList<SurveyImagePickerChoice> Choices { get; set; } = new List<SurveyImagePickerChoice>();

    }
}