namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyBooleanItemBuilder<TEntity> :
        SurveyItemBuilderBase<TEntity, SurveyBooleanItem>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public SurveyBooleanItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public SurveyBooleanItemBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public SurveyBooleanItemBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public SurveyBooleanItemBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public SurveyBooleanItemBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public SurveyBooleanItemBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public SurveyBooleanItemBuilder<TEntity> HasLabel(string label)
        {
            _item.Label = label;
            return this;
        }

        public SurveyBooleanItemBuilder<TEntity> HasLabelTrue(string labelTrue)
        {
            _item.LabelTrue = labelTrue;
            return this;
        }

        public SurveyBooleanItemBuilder<TEntity> HasLabelFalse(string labelFalse)
        {
            _item.LabelFalse = labelFalse;
            return this;
        }
    }
}