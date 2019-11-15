namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyCheckboxItemBuilder<TEntity> : IBuilder<SurveyItem> where TEntity : new()
    {
        private SurveyCheckboxItem _item = new SurveyCheckboxItem();

        public SurveyCheckboxItemBuilder()
        {
            _item.Type = "checkbox";
        }
       
        public SurveyCheckboxItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }


        public SurveyCheckboxItemBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> IsNotRequired()
        {
            _item.IsRequired = false;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> IsVisible()
        {
            _item.IsVisible = true;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> IsNotVisible()
        {
            _item.IsVisible = false;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> HasColumnCount(int value)
        {
            _item.ColCount = value;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> SetChoicesOrder(SurveyChoicesOrderEnum order)
        {
            string enumName = Enum.GetName(typeof(SurveyChoicesOrderEnum), order);
            if (enumName != null) _item.ChoicesOrder = enumName.ToLowerInvariant();
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> HasOtherChoide(string choiceText)
        {
            _item.OtherText = choiceText;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> HasSelectAllChoide(string choiceText)
        {
            _item.HasSelectAll = true;
            _item.SelectAllText = choiceText;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> HasSelectNoneChoide(string choiceText)
        {
            _item.HasNone = true;
            _item.NoneText = choiceText;
            return this;
        }

        public SurveyCheckboxItemBuilder<TEntity> AddChoide(string choiceValue, string choiceText)
        {
            _item.Choices.Add(new SurveyCheckboxChoice() { Value = choiceValue, Text = choiceText });
            return this;
        }

        public SurveyItem Build()
        {
            return _item;
        }
    }
}