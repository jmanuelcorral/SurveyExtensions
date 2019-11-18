namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.ChoiceItems;

    public class SurveyRatinItemBuilder<TEntity> : 
        SurveyItemBuilderBase<TEntity, SurveyRatingItem>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public SurveyRatinItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public SurveyRatinItemBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> HasRateMin(int value)
        {
            _item.RateMin = value;
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> HasRateMax(int value)
        {
            _item.RateMax = value;
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> HasRateStep(int value)
        {
            _item.RateStep = value;
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> AddRateValue(string value, string text)
        {
            _item.RateValues.Add(new SurveyChoice() { Value = value, Text = text});
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> HasMinRateDescription(string value)
        {
            _item.MinRateDescription = value;
            return this;
        }

        public SurveyRatinItemBuilder<TEntity> HasMaxRateDescription(string value)
        {
            _item.MaxRateDescription = value;
            return this;
        }
    }
}