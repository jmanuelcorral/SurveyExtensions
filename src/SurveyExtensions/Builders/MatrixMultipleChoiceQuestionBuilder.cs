namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.QuestionElements;
    using SurveyExtensions.Elements.Questions;
    using SurveyExtensions.Enums;

    public class MatrixMultipleChoiceQuestionBuilder<TEntity> : 
        QuestionBuilderBase<TEntity, MatrixMultipleChoiceQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public MatrixMultipleChoiceQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public MatrixMultipleChoiceQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> SetIsAllRowRequired()
        {
            _item.IsAllRowRequired = true;
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> HasTotalText(string value)
        {
            _item.TotalText= value;
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> HasCellType(CellTypesEnum cellType)
        {
            string enumName = Enum.GetName(typeof(CellTypesEnum), cellType);
            if (enumName != null) _item.CellType = enumName.ToLowerInvariant();
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> AddColumn(string value, string text, CellTypesEnum cellType)
        {
            string ct = null;
            string enumName = Enum.GetName(typeof(CellTypesEnum), cellType);
            if (enumName != null) ct = enumName.ToLowerInvariant();
            _item.Columns.Add(new MatrixMultipleChoiceChoice() { Value = value, Text = text, CellType = ct });
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> AddColumn(string value, string text)
        {
            string ct = null;
            _item.Columns.Add(new MatrixMultipleChoiceChoice() { Value = value, Text = text, CellType = ct });
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> AddRow(string value, string text)
        {
            _item.Rows.Add(new Choice() { Value = value, Text = text });
            return this;
        }

        public MatrixMultipleChoiceQuestionBuilder<TEntity> AddChoice(string value, string text)
        {
            _item.Choices.Add(new Choice() { Value = value, Text = text });
            return this;
        }
    }
}