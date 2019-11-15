namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyRadiogroupItemBuilder<TEntity> : IBuilder<SurveyItem> where TEntity : new()
    {
        private SurveyRadiogroupItem _item = new SurveyRadiogroupItem();

        public SurveyRadiogroupItemBuilder()
        {
            _item.Type = "radiogroup";
        }
       
        public SurveyRadiogroupItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }

        public SurveyRadiogroupItemBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public SurveyRadiogroupItemBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }


        public SurveyRadiogroupItemBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public SurveyRadiogroupItemBuilder<TEntity> IsNotRequired()
        {
            _item.IsRequired = false;
            return this;
        }

        public SurveyRadiogroupItemBuilder<TEntity> IsVisible()
        {
            _item.IsVisible = true;
            return this;
        }

        public SurveyRadiogroupItemBuilder<TEntity> IsNotVisible()
        {
            _item.IsVisible = false;
            return this;
        }

        public SurveyRadiogroupItemBuilder<TEntity> HasColumnCount(int value)
        {
            _item.ColCount = value;
            return this;
        }

        public SurveyRadiogroupItemBuilder<TEntity> SetChoicesOrder(SurveyChoicesOrderEnum order)
        {
            string enumName = Enum.GetName(typeof(SurveyChoicesOrderEnum), order);
            if (enumName != null) _item.ChoicesOrder = enumName.ToLowerInvariant();
            return this;
        }

        public SurveyRadiogroupItemBuilder<TEntity> HasOtherChoice(string choiceText)
        {
            _item.HasOther = true;
            _item.OtherText = choiceText;
            return this;
        }

        public SurveyRadiogroupItemBuilder<TEntity> AddChoice(string choiceValue, string choiceText)
        {
            _item.Choices.Add(new SurveyChoice() { Value = choiceValue, Text = choiceText });
            return this;
        }

        public SurveyItem Build()
        {
            return _item;
        }
    }
}