namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.QuestionElements;
    using SurveyExtensions.Elements.Questions;
    using SurveyExtensions.Enums;

    public class CheckboxQuestionBuilder<TEntity> : 
        QuestionBuilderBase<TEntity, CheckboxQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public CheckboxQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public CheckboxQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> HasColumnCount(int value)
        {
            _item.ColCount = value;
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> SetChoicesOrder(ChoicesOrderOprions order)
        {
            string enumName = Enum.GetName(typeof(ChoicesOrderOprions), order);
            if (enumName != null) _item.ChoicesOrder = enumName.ToLowerInvariant();
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> HasOtherChoice(string choiceText)
        {
            _item.OtherText = choiceText;
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> HasSelectAllChoice(string choiceText)
        {
            _item.HasSelectAll = true;
            _item.SelectAllText = choiceText;
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> HasSelectNoneChoice(string choiceText)
        {
            _item.HasNone = true;
            _item.NoneText = choiceText;
            return this;
        }

        public CheckboxQuestionBuilder<TEntity> AddChoice(string choiceValue, string choiceText)
        {
            _item.Choices.Add(new Choice() { Value = choiceValue, Text = choiceText });
            return this;
        }

    }
}