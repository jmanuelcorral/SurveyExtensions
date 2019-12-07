namespace SurveyExtensions.Elements.Questions
{
    public class FileQuestion : Question
    {
        public FileQuestion()
        {
            Type = "file";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public bool ShowPreview { get; set; }
        public int ImageHeight { get; set; }
        public int ImageWidth { get; set; }
        public bool StoreDataAsText { get; set; }
        public int MaxSize { get; set; } = 0;
    }
}