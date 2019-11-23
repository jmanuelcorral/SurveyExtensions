namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.ChoiceItems;
    using System.Collections.Generic;

    public class ImagePickerQuestion : SurveyQuestion
    {
        public ImagePickerQuestion()
        {
            Type = "imagepicker";
        }

        public string ChoicesOrder { get; set; }

        public int ColCount { get; set; } = 0;

        public IList<ImagePickerChoice> Choices { get; set; } = new List<ImagePickerChoice>();

    }
}