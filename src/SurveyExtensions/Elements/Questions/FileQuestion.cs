namespace SurveyExtensions.Elements.Questions
{
    public class FileQuestion : SurveyQuestion
    {
        public FileQuestion()
        {
            Type = "file";
        }

        public int MaxSize { get; set; } = 0;
    }
}