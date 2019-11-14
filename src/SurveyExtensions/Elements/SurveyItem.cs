namespace SurveyExtensions.Elements
{
    using System;

    public class SurveyItem
    {
        public string Name { get; set; }
       
    }

    public class SurveyPageElement : SurveyItem
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public Boolean IsRequired { get; set; } = false;
    }

    public class SurveyInputItem : SurveyPageElement
    {
       
        public string PlaceHolder { get; set; }
        public string InputType { get; set; }
    }
}