namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyCommentItemBuilder<TEntity> :
        SurveyItemBuilderBase<TEntity, SurveyCommentItem>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public SurveyCommentItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public SurveyCommentItemBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public SurveyCommentItemBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public SurveyCommentItemBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public SurveyCommentItemBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public SurveyCommentItemBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public SurveyCommentItemBuilder<TEntity> HasPlaceHolder(string placeholder)
        {
            _item.PlaceHolder = placeholder;
            return this;
        }

        public SurveyCommentItemBuilder<TEntity> HasRows(int rows)
        {
            _item.Rows = rows;
            return this;
        }
    }
}