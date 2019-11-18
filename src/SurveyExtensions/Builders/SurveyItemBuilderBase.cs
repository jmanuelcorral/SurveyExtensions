namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public abstract class SurveyItemBuilderBase<TEntity, TItem> : IBuilder<SurveyItem> 
        where TEntity : new()
        where TItem : SurveyPageElement
    {
        protected TItem _item = (TItem)(Activator.CreateInstance(typeof(TItem)));

        public SurveyItem Build()
        {
            return _item;
        }
    }
}