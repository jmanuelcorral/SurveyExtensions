namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.ChoiceItems;
    using SurveyExtensions.Elements.Questions;
    using SurveyExtensions.Enums;

    public class MatrixSingleChoiceQuestionBuilder<TEntity> : 
        QuestionBuilderBase<TEntity, MatrixSingleChoiceQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public MatrixSingleChoiceQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public MatrixSingleChoiceQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public MatrixSingleChoiceQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public MatrixSingleChoiceQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public MatrixSingleChoiceQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public MatrixSingleChoiceQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public MatrixSingleChoiceQuestionBuilder<TEntity> SetIsAllRowRequired()
        {
            _item.IsAllRowRequired = true;
            return this;
        }

        public MatrixSingleChoiceQuestionBuilder<TEntity> AddColumn(string value, string text)
        {
            _item.Columns.Add(new Choice() { Value = value, Text = text });
            return this;
        }
        public MatrixSingleChoiceQuestionBuilder<TEntity> AddRow(string value, string text)
        {
            _item.Rows.Add(new Choice() { Value = value, Text = text });
            return this;
        }

    }
}