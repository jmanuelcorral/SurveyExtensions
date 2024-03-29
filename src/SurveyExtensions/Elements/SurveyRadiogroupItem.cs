﻿namespace SurveyExtensions.Elements
{
    using System.Collections.Generic;

    public class SurveyRadiogroupItem : SurveyPageElement
    {
       
        public string ChoicesOrder { get; set; }
        public int ColCount { get; set; }
        public bool HasOther { get; set; }
        public string OtherText { get; set; }

        public IList<SurveyChoice> Choices { get; set; } = new List<SurveyChoice>();

    }
}