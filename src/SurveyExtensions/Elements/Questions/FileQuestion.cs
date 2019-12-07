namespace SurveyExtensions.Elements.Questions
{
    public class FileQuestion : Question
    {
        public FileQuestion()
        {
            Type = "file";
        }

        public int MaxSize { get; set; } = 0;
    }
}