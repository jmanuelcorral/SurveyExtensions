namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.Questions;
    using SurveyExtensions.Enums;

    public class MultipleTextQuestionBuilder<TEntity> :
        QuestionBuilderBase<TEntity, MultipleTextQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {
        public MultipleTextQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public MultipleTextQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public MultipleTextQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public MultipleTextQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public MultipleTextQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public MultipleTextQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public MultipleTextQuestionBuilder<TEntity> HasColumnCount(int value)
        {
            _item.ColCount = value;
            return this;
        }


        public MultipleTextQuestionBuilder<TEntity> AddItem(string text)
        {
            _item.Items.Add(new Elements.ChoiceItems.MultiTextItem() { Name = text });
            return this;
        }
    }
}