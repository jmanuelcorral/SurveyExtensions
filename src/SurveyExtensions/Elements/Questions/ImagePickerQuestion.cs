namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.QuestionElements;
    using System.Collections.Generic;

    public class ImagePickerQuestion : Question
    {
        public ImagePickerQuestion()
        {
            Type = "imagepicker";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public string ChoicesOrder { get; set; }
        public int ColCount { get; set; } = 0;
        public IList<ImagePickerChoice> Choices { get; set; } = new List<ImagePickerChoice>();

    }
}