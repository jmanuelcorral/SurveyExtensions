﻿namespace SurveyExtensions.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Elements;
    using Helpers;
    using SurveyExtensions.Enums;

    public class PageBuilder<TEntity>: IBuilder<SurveyPage> where TEntity : new()
    {
        private SurveyPage _item = new SurveyPage();
        private List<IBuilder<SurveyItem>> elementsBuilder = new List<IBuilder<SurveyItem>>();
        
        public PageBuilder<TEntity> HasName(string name)
        {
            _item.Name = name;
            return this;
        }

        public PageBuilder<TEntity> AddSingleInputQuestion<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<SimgleItemQuestionBuilder<TEntity>> inputBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new SimgleItemQuestionBuilder<TEntity>();
            inputBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddSingleInputQuestion<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title, string placeholder, SingleInputTypesEnum inputType)
        {
            return AddSingleInputQuestion(expression, 
                x => x.HasTitle(title)
                       .HasPlaceHolder(placeholder)
                       .SetInputType(inputType));
        }

        public PageBuilder<TEntity> AddCommentInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<CommentQuestionBuilder<TEntity>> commentBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new CommentQuestionBuilder<TEntity>();
            commentBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddCommentInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title, string placeholder, int rows)
        {
            return AddCommentInput(expression,
                x => x.HasTitle(title)
                       .HasPlaceHolder(placeholder)
                       .HasRows(7));
        }

        public PageBuilder<TEntity> AddCheckboxInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<CheckboxQuestionBuilder<TEntity>> checkboxBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new CheckboxQuestionBuilder<TEntity>();
            checkboxBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddCheckboxInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title)
        {
            return AddCheckboxInput(expression, x => x.HasTitle(title));
        }

        public PageBuilder<TEntity> AddRadiogroup<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<RadiogroupQuestionBuilder<TEntity>> radiogroupBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new RadiogroupQuestionBuilder<TEntity>();
            radiogroupBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddRadiogroup<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title)
        {
            return AddRadiogroup(expression, x => x.HasTitle(title));
        }

        public PageBuilder<TEntity> AddDropdown<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<DropdownQuestionBuilder<TEntity>> dropDownBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new DropdownQuestionBuilder<TEntity>();
            dropDownBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddDropdown<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title)
        {
            return AddRadiogroup(expression, x => x.HasTitle(title));
        }

        public PageBuilder<TEntity> AddRating<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<RatingQuestionBuilder<TEntity>> ratingBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new RatingQuestionBuilder<TEntity>();
            ratingBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddRating<TProperty>(Expression<Func<TEntity, TProperty>> expression, 
            string title, string description, int rateMin, int rateMax, int rateStep)
        {
            return AddRating(expression, 
                x => x.HasTitle(title)
                        .HasDescription(description)
                        .HasRateMin(rateMin)
                        .HasRateMax(rateMax)
                        .HasRateStep(rateStep));
        }

        public PageBuilder<TEntity> AddImagePickerInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<ImagePickerQuestionBuilder<TEntity>> imagePickerBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new ImagePickerQuestionBuilder<TEntity>();
            imagePickerBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddImagePickerInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title)
        {
            return AddImagePickerInput(expression, x => x.HasTitle(title));
        }

        public PageBuilder<TEntity> AddBooleanInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<BooleanQuestionBuilder<TEntity>> booleanBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new BooleanQuestionBuilder<TEntity>();
            booleanBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddBooleanInput<TProperty>(Expression<Func<TEntity, TProperty>> expression, string title, string abel, string labelTrue, string labelNo)
        {
            return AddImagePickerInput(expression, x => x.HasTitle(title));
        }


        public PageBuilder<TEntity> AddHtmlEditor<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<HtmlEditorQuestionBuilder<TEntity>> htmlEditorBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new HtmlEditorQuestionBuilder<TEntity>();
            htmlEditorBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddFile<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<FileQuestionBuilder<TEntity>> fileBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new FileQuestionBuilder<TEntity>();
            fileBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddMAtrixSingleChoice<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<MatrixSingleChoiceQuestionBuilder<TEntity>> matrixSingleChoiceQuestionBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new MatrixSingleChoiceQuestionBuilder<TEntity>();
            matrixSingleChoiceQuestionBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
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