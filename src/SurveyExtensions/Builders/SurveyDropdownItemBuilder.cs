namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyDropdownItemBuilder<TEntity> : 
        SurveyItemBuilderBase<TEntity, SurveyDropdownItem>,
        IBuilder<SurveyItem> where TEntity : new()
    {
        public SurveyDropdownItemBuilder()
        {
            _item.Type = "dropdown";
        }

        public SurveyDropdownItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }

        public SurveyDropdownItemBuilder<TEntity> HasTitle(string value) 
        {
            _item.Title = value;
            return this;
        }

        public SurveyDropdownItemBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public SurveyDropdownItemBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public SurveyDropdownItemBuilder<TEntity> IsNotRequired()
        {
            _item.IsRequired = false;
            return this;
        }

        public SurveyDropdownItemBuilder<TEntity> IsVisible()
        {
            _item.Visible = true;
            return this;
        }

        public SurveyDropdownItemBuilder<TEntity> IsNotVisible()
        {
            _item.Visible = false;
            return this;
        }

        public SurveyDropdownItemBuilder<TEntity> SetChoicesOrder(SurveyChoicesOrderEnum order)
        {
            string enumName = Enum.GetName(typeof(SurveyChoicesOrderEnum), order);
            if (enumName != null) _item.ChoicesOrder = enumName.ToLowerInvariant();
            return this;
        }

        public SurveyDropdownItemBuilder<TEntity> HasOtherChoice(string choiceText)
        {
            _item.HasOther = true;
            _item.OtherText = choiceText;
            return this;
        }

        public SurveyDropdownItemBuilder<TEntity> AddChoice(string choiceValue, string choiceText)
        {
            _item.Choices.Add(new SurveyChoice() { Value = choiceValue, Text = choiceText });
            return this;
        }

    }
}