namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.QuestionElements;
    using System.Collections.Generic;

    public class MatrixMultipleChoiceQuestion : Question
    {
        public MatrixMultipleChoiceQuestion()
        {
            Type = "matrixdropdown";
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public string CellType { get; set; }
        public string TotalText { get; set; }
        public IList<MatrixMultipleChoiceChoice> Columns { get; set; } = new List<MatrixMultipleChoiceChoice>();
        public IList<Choice> Rows { get; set; } = new List<Choice>();
        public IList<Choice> Choices { get; set; } = new List<Choice>();
    }
}