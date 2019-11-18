namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.ChoiceItems;

    public class SurveyDropdownItemBuilder<TEntity> : 
        SurveyItemBuilderBase<TEntity, SurveyDropdownItem, SurveyDropdownItemBuilder<TEntity>>,
        IBuilder<SurveyItem> where TEntity : new()
    {
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