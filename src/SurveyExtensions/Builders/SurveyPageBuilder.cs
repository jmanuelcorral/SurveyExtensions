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

        public SurveyPageBuilder<TEntity> AddCommentInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SurveyCommentItemBuilder<TEntity>> commentBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SurveyCommentItemBuilder<TEntity>();
            commentBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public SurveyPageBuilder<TEntity> AddCommentInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title, string placeholder, int rows)
        {
            return AddCommentInput(expression,
                x => x.HasTitle(title)
                       .HasPlaceHolder(placeholder)
                       .HasRows(7));
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

        public SurveyPageBuilder<TEntity> AddDropdown<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SurveyDropdownItemBuilder<TEntity>> dropDownBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SurveyDropdownItemBuilder<TEntity>();
            dropDownBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public SurveyPageBuilder<TEntity> AddDropdown<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title)
        {
            return AddRadiogroup(expression, x => x.HasTitle(title));
        }

        public SurveyPageBuilder<TEntity> AddRating<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SurveyRatinItemBuilder<TEntity>> ratingBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SurveyRatinItemBuilder<TEntity>();
            ratingBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public SurveyPageBuilder<TEntity> AddRating<TProperty>(Expression<Func<TEntity, TProperty>> expression, 
            string title, string description, int rateMin, int rateMax, int rateStep)
        {
            return AddRating(expression, 
                x => x.HasTitle(title)
                        .HasDescription(description)
                        .HasRateMin(rateMin)
                        .HasRateMax(rateMax)
                        .HasRateStep(rateStep));
        }

        public SurveyPageBuilder<TEntity> AddImagePickerInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SurveyImagePickerItemBuilder<TEntity>> imagePickerBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SurveyImagePickerItemBuilder<TEntity>();
            imagePickerBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public SurveyPageBuilder<TEntity> AddImagePickerInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title)
        {
            return AddImagePickerInput(expression, x => x.HasTitle(title));
        }

        public SurveyPageBuilder<TEntity> AddBooleanInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SurveyBooleanItemBuilder<TEntity>> booleanBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SurveyBooleanItemBuilder<TEntity>();
            booleanBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public SurveyPageBuilder<TEntity> AddBooleanInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title, string abel, string labelTrue, string labelNo)
        {
            return AddImagePickerInput(expression, x => x.HasTitle(title));
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