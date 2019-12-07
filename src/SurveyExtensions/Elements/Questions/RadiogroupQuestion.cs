﻿namespace SurveyExtensions.Elements.Questions
{
    using SurveyExtensions.Elements.QuestionElements;
    using System.Collections.Generic;

    public class RadiogroupQuestion : Question
    {

        public RadiogroupQuestion()
        {
            Type = "radiogroup";
        }
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsRequired { get; set; } = false;
        public bool StartWithNewLine { get; set; } = true;
        public string ChoicesOrder { get; set; }
        public int ColCount { get; set; }
        public bool HasOther { get; set; }
        public string OtherText { get; set; }

        public IList<Choice> Choices { get; set; } = new List<Choice>();

    }
}