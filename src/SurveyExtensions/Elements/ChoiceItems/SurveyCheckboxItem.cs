﻿namespace SurveyExtensions.Elements.ChoiceItems
{
    using System.Collections.Generic;

    public class SurveyCheckboxItem : SurveyPageElement
    {
        public SurveyCheckboxItem()
        {
            Type = "checkbox";
        }

        public string ChoicesOrder { get; set; }

        public int ColCount { get; set; }

        public IList<SurveyChoice> Choices { get; set; } = new List<SurveyChoice>();


        public string OtherText { get; set; }

        public bool HasSelectAll { get; set; } = false;
        public string SelectAllText { get; set; }

        public bool HasNone { get; set; } = false;
        public string NoneText { get; set; }
    }
}