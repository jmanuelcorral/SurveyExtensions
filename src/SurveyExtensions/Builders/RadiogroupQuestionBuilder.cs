namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.ChoiceItems;
    using SurveyExtensions.Elements.Questions;
    using SurveyExtensions.Enums;

    public class RadiogroupQuestionBuilder<TEntity> :
        QuestionBuilderBase<TEntity, RadiogroupQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public RadiogroupQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public RadiogroupQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public RadiogroupQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public RadiogroupQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public RadiogroupQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public RadiogroupQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public RadiogroupQuestionBuilder<TEntity> HasColumnCount(int value)
        {
            _item.ColCount = value;
            return this;
        }

        public RadiogroupQuestionBuilder<TEntity> SetChoicesOrder(ChoicesOrderEnum order)
        {
            string enumName = Enum.GetName(typeof(ChoicesOrderEnum), order);
            if (enumName != null) _item.ChoicesOrder = enumName.ToLowerInvariant();
            return this;
        }

        public RadiogroupQuestionBuilder<TEntity> HasOtherChoice(string choiceText)
        {
            _item.HasOther = true;
            _item.OtherText = choiceText;
            return this;
        }

        public RadiogroupQuestionBuilder<TEntity> AddChoice(string choiceValue, string choiceText)
        {
            _item.Choices.Add(new Choice() { Value = choiceValue, Text = choiceText });
            return this;
        }
    }
}