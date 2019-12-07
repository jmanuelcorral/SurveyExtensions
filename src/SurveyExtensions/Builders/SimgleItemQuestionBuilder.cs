namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.Questions;
    using SurveyExtensions.Enums;

    public class SimgleItemQuestionBuilder<TEntity> :
        QuestionBuilderBase<TEntity, SingleInputQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {
        public SimgleItemQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public SimgleItemQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public SimgleItemQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public SimgleItemQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public SimgleItemQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public SimgleItemQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public SimgleItemQuestionBuilder<TEntity> SetInputType(SingleInputTypes inputType)
        {
            string enumName = Enum.GetName(typeof(SingleInputTypes) ,inputType);
            if (enumName != null)
            {
                _item.InputType = enumName.ToLowerInvariant();
            }

            return this;
        }

        public SimgleItemQuestionBuilder<TEntity> HasPlaceHolder(string placeholder)
        {
            _item.PlaceHolder = placeholder;
            return this;
        }
    }
}