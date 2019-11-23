namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.Questions;

    public class FileQuestionBuilder<TEntity> :
        QuestionBuilderBase<TEntity, FileQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public FileQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }

        public FileQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public FileQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public FileQuestionBuilder<TEntity> HasMaxSize(int maxSize)
        {
            _item.MaxSize = maxSize;
            return this;
        }

    }
}