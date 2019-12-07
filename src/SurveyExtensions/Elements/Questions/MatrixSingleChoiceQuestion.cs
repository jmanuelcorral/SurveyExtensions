﻿namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.QuestionElements;
    using System.Collections.Generic;

    public class MatrixSingleChoiceQuestion : Question
    {
        public MatrixSingleChoiceQuestion()
        {
            Type = "matrix";
        }

        public IList<Choice> Columns { get; set; } = new List<Choice>();
        public IList<Choice> Rows { get; set; } = new List<Choice>();

        public bool IsAllRowRequired { get; set; } = false;
    }
}