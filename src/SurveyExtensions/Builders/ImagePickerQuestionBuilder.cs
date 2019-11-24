namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.QuestionElements;
    using SurveyExtensions.Elements.Questions;
    using SurveyExtensions.Enums;

    public class ImagePickerQuestionBuilder<TEntity> : 
        QuestionBuilderBase<TEntity, ImagePickerQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public ImagePickerQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public ImagePickerQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public ImagePickerQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public ImagePickerQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public ImagePickerQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public ImagePickerQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public ImagePickerQuestionBuilder<TEntity> HasColumnCount(int value)
        {
            _item.ColCount = value;
            return this;
        }

        public ImagePickerQuestionBuilder<TEntity> SetChoicesOrder(ChoicesOrderEnum order)
        {
            string enumName = Enum.GetName(typeof(ChoicesOrderEnum), order);
            if (enumName != null) _item.ChoicesOrder = enumName.ToLowerInvariant();
            return this;
        }


        public ImagePickerQuestionBuilder<TEntity> AddChoice(string choiceValue, string choiceText, string imageLink)
        {
            _item.Choices.Add(
                new ImagePickerChoice() 
                { 
                    Value = choiceValue, 
                    Text = choiceText,
                    ImageLink = imageLink,
                });
            return this;
        }

    }
}