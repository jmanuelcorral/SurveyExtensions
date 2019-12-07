namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.QuestionElements;
    using SurveyExtensions.Elements.Questions;
    using SurveyExtensions.Enums;

    public class DropdownQuestionBuilder<TEntity> : 
        QuestionBuilderBase<TEntity, DropdownIQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public DropdownQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public DropdownQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public DropdownQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public DropdownQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public DropdownQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public DropdownQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public DropdownQuestionBuilder<TEntity> SetChoicesOrder(ChoicesOrderOprions order)
        {
            string enumName = Enum.GetName(typeof(ChoicesOrderOprions), order);
            if (enumName != null)
            {
                _item.ChoicesOrder = enumName.ToLowerInvariant();
            }

            return this;
        }

        public DropdownQuestionBuilder<TEntity> HasOtherChoice(string choiceText)
        {
            _item.HasOther = true;
            _item.OtherText = choiceText;
            return this;
        }

        public DropdownQuestionBuilder<TEntity> AddChoice(string choiceValue, string choiceText)
        {
            _item.Choices.Add(new Choice() { Value = choiceValue, Text = choiceText });
            return this;
        }

        public DropdownQuestionBuilder<TEntity> AutoChoices(int minChoice, int maxChoice, int choiceStep)
        {
            _item.ChoicesMin = minChoice;
            _item.ChoicesMax = maxChoice;
            _item.ChoicesStep = choiceStep;
            return this;
        }
    }
}