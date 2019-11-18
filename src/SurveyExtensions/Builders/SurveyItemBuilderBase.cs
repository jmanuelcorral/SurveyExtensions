namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyItemBuilderBase<TEntity, TItem, TBuilder> : IBuilder<SurveyItem> 
        where TEntity : new()
        where TItem : SurveyPageElement
        where TBuilder : SurveyItemBuilderBase<TEntity, TItem, TBuilder>
    {
        protected TItem _item = (TItem)(Activator.CreateInstance(typeof(TItem)));

        public SurveyItemBuilderBase<TEntity, TItem, TBuilder> HasName(string value)
        {
            _item.Name = value;
            return (TBuilder)this;
        }

        public SurveyItemBuilderBase<TEntity, TItem, TBuilder> HasTitle(string value)
        {
            _item.Title = value;
            return (TBuilder)this;
        }

        public SurveyItemBuilderBase<TEntity, TItem, TBuilder> HasDescription(string value)
        {
            _item.Description = value;
            return (TBuilder)this;
        }

        public SurveyItemBuilderBase<TEntity, TItem, TBuilder> IsRequired()
        {
            _item.IsRequired = true;
            return (TBuilder)this;
        }

        public SurveyItemBuilderBase<TEntity, TItem, TBuilder> IsNotVisible()
        {
            _item.Visible = false;
            return (TBuilder)this;
        }

        public SurveyItemBuilderBase<TEntity, TItem, TBuilder> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return (TBuilder)this;
        }
        public SurveyItem Build()
        {
            return _item;
        }
    }
}