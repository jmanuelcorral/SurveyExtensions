namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.Questions;

    public class HtmlEditorQuestionBuilder<TEntity> :
        QuestionBuilderBase<TEntity, HtmlEditorQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public HtmlEditorQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }

        public HtmlEditorQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public HtmlEditorQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public HtmlEditorQuestionBuilder<TEntity> HasHtml(string html)
        {
            _item.Html = html;
            return this;
        }

    }
}