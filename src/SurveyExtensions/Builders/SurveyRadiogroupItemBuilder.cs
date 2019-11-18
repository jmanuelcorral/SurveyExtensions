namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.ChoiceItems;

    public class SurveyRadiogroupItemBuilder<TEntity> :
        SurveyItemBuilderBase<TEntity, SurveyRadiogroupItem, SurveyRadiogroupItemBuilder<TEntity>>,
        IBuilder<SurveyItem> where TEntity : new()
    {
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
    }
}