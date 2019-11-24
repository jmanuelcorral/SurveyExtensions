namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.ChoiceItems;
    using System.Collections.Generic;

    public class MatrixMultipleChoiceQuestion : SurveyQuestion
    {
        public MatrixMultipleChoiceQuestion()
        {
            Type = "matrixdropdown";
        }
        public string CellType { get; set; }
        public string TotalText { get; set; }

        public IList<MatrixMultipleChoiceChoice> Columns { get; set; } = new List<MatrixMultipleChoiceChoice>();
        public IList<Choice> Rows { get; set; } = new List<Choice>();
        public IList<Choice> Choices { get; set; } = new List<Choice>();

        public bool IsAllRowRequired { get; set; } = false;
    }
}