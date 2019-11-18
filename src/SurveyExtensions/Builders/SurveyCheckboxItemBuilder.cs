namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.ChoiceItems;

    public class SurveyCheckboxItemBuilder<TEntity> : 
        SurveyItemBuilderBase<TEntity, SurveyCheckboxItem, SurveyCheckboxItemBuilder<TEntity>>,
        IBuilder<SurveyItem> where TEntity : new()
    {
        public SurveyCheckboxItemBuilder<TEntity> HasColumnCount(int value)
        {
            _item.ColCount = value;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> SetChoicesOrder(SurveyChoicesOrderEnum order)
        {
            string enumName = Enum.GetName(typeof(SurveyChoicesOrderEnum), order);
            if (enumName != null) _item.ChoicesOrder = enumName.ToLowerInvariant();
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> HasOtherChoice(string choiceText)
        {
            _item.OtherText = choiceText;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> HasSelectAllChoice(string choiceText)
        {
            _item.HasSelectAll = true;
            _item.SelectAllText = choiceText;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> HasSelectNoneChoice(string choiceText)
        {
            _item.HasNone = true;
            _item.NoneText = choiceText;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> AddChoice(string choiceValue, string choiceText)
        {
            _item.Choices.Add(new SurveyChoice() { Value = choiceValue, Text = choiceText });
            return this;
        }

    }
}