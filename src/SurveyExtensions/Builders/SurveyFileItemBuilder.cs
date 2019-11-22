namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyFileItemBuilder<TEntity> :
        SurveyItemBuilderBase<TEntity, SurveyFileItem>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public SurveyFileItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }

        public SurveyFileItemBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public SurveyFileItemBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public SurveyFileItemBuilder<TEntity> HasMaxSize(int maxSize)
        {
            _item.MaxSize = maxSize;
            return this;
        }

    }
}