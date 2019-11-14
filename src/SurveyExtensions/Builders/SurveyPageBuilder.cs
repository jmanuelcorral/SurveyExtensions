namespace SurveyExtensions.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Elements;
    using Helpers;

    public class SurveyPageBuilder<TEntity>: SurveyItemBuilder where TEntity : new()
    {
        private SurveyPage _item = new SurveyPage();
        private List<SurveyItemBuilder> elementsBuilder = new List<SurveyItemBuilder>();
        
        public SurveyPageBuilder<TEntity> HasName(string name)
        {
            _item.Name = name;
            return this;
        }

        public SurveyPageBuilder<TEntity> AddSingleInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SurveyInputItemBuilder<TEntity>> inputBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SurveyInputItemBuilder<TEntity>();
            inputBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public SurveyPageBuilder<TEntity> AddSingleInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string placeholder, string title, SurveyInputType inputType)
        {
            return AddSingleInput(expression, x => x.HasTitle(title).HasPlaceHolder(placeholder).SetInputType(inputType));
        }

        public override SurveyItem Build()
        {
            foreach (var surveyItemBuilder in elementsBuilder)
            {
                _item.Elements.Add(surveyItemBuilder.Build());
            }
            return _item;
        }
    }
}