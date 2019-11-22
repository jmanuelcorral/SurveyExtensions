namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.ChoiceItems;

    public class SurveyImagePickerItemBuilder<TEntity> : 
        SurveyItemBuilderBase<TEntity, SurveyImagePickerItem>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public SurveyImagePickerItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public SurveyImagePickerItemBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public SurveyImagePickerItemBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public SurveyImagePickerItemBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public SurveyImagePickerItemBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public SurveyImagePickerItemBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public SurveyImagePickerItemBuilder<TEntity> HasColumnCount(int value)
        {
            _item.ColCount = value;
            return this;
        }

        public SurveyImagePickerItemBuilder<TEntity> SetChoicesOrder(SurveyChoicesOrderEnum order)
        {
            string enumName = Enum.GetName(typeof(SurveyChoicesOrderEnum), order);
            if (enumName != null) _item.ChoicesOrder = enumName.ToLowerInvariant();
            return this;
        }


        public SurveyImagePickerItemBuilder<TEntity> AddChoice(string choiceValue, string choiceText, string imageLink)
        {
            _item.Choices.Add(
                new SurveyImagePickerChoice() 
                { 
                    Value = choiceValue, 
                    Text = choiceText,
                    ImageLink = imageLink,
                });
            return this;
        }

    }
}