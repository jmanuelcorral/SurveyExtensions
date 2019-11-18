namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyCommentItemBuilder<TEntity> :
        SurveyItemBuilderBase<TEntity, SurveyCommentItem, SurveyCommentItemBuilder<TEntity>>,
        IBuilder<SurveyItem> where TEntity : new()
    {
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