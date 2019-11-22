namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyHtmlEditorItemBuilder<TEntity> :
        SurveyItemBuilderBase<TEntity, SurveyHtmlEditorItem>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public SurveyHtmlEditorItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }

        public SurveyHtmlEditorItemBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public SurveyHtmlEditorItemBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public SurveyHtmlEditorItemBuilder<TEntity> HasHtml(string html)
        {
            _item.Html = html;
            return this;
        }

    }
}