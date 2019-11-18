namespace SurveyExtensions.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Elements;
    using Helpers;

    public class SurveyPageBuilder<TEntity>: IBuilder<SurveyPage> where TEntity : new()
    {
        private SurveyPage _item = new SurveyPage();
        private List<IBuilder<SurveyItem>> elementsBuilder = new List<IBuilder<SurveyItem>>();
        
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

        public SurveyPageBuilder<TEntity> AddSingleInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title, string placeholder, SurveyInputType inputType)
        {
            return AddSingleInput(expression, 
                x => x.HasTitle(title)
                       .HasPlaceHolder(placeholder)
                       .SetInputType(inputType));
        }


        public SurveyPageBuilder<TEntity> AddCheckboxInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SurveyCheckboxItemBuilder<TEntity>> checkboxBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SurveyCheckboxItemBuilder<TEntity>();
            checkboxBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public SurveyPageBuilder<TEntity> AddCheckboxInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title)
        {
            return AddCheckboxInput(expression, x => x.HasTitle(title));
        }

        public SurveyPageBuilder<TEntity> AddRadiogroup<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SurveyRadiogroupItemBuilder<TEntity>> radiogroupBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SurveyRadiogroupItemBuilder<TEntity>();
            radiogroupBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public SurveyPageBuilder<TEntity> AddRadiogroup<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title)
        {
            return AddRadiogroup(expression, x => x.HasTitle(title));
        }

        public SurveyPageBuilder<TEntity> AddDropdown<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SurveyDropdownItemBuilder<TEntity>> radiogroupBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SurveyDropdownItemBuilder<TEntity>();
            radiogroupBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public SurveyPageBuilder<TEntity> AddDropdown<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title)
        {
            return AddRadiogroup(expression, x => x.HasTitle(title));
        }

        public SurveyPage Build()
        {
            foreach (var surveyItemBuilder in elementsBuilder)
            {
                _item.Elements.Add(surveyItemBuilder.Build());
            }
            return _item;
        }
    }
}