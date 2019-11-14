namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyInputItemBuilder<TEntity> : SurveyItemBuilder where TEntity : new()
    {
        private SurveyInputItem _item = new SurveyInputItem();

        public SurveyInputItemBuilder()
        {
            _item.Type = "text";
            _item.InputType = "text";
        }

        
      public SurveyInputItemBuilder<TEntity> SetInputType(SurveyInputType inputType)
        {
            string enumName = Enum.GetName(typeof(SurveyInputType) ,inputType);
            if (enumName != null) _item.InputType = enumName.ToLowerInvariant();
            return this;
        }

        public SurveyInputItemBuilder<TEntity> HasPlaceHolder(string placeholder)
        {
            _item.PlaceHolder = placeholder;
            return this;
        }

        public SurveyInputItemBuilder<TEntity> HasName(string name)
        {
            _item.Name = name;
            return this;
        }

        public SurveyInputItemBuilder<TEntity> HasTitle(string title)
        {
            _item.Title = title;
            return this;
        }

        public SurveyInputItemBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public override SurveyItem Build()
        {
            return _item;
        }
    }

    public abstract class SurveyItemBuilder
    {
        
        public abstract SurveyItem Build();
    }
}