namespace SurveyExtensions.Builders
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

        public PageBuilder<TEntity> AddMatrixSingleChoice<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<MatrixSingleChoiceQuestionBuilder<TEntity>> matrixSingleChoiceQuestionBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new MatrixSingleChoiceQuestionBuilder<TEntity>();
            matrixSingleChoiceQuestionBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddMatrixMutipleChoice<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<MatrixMultipleChoiceQuestionBuilder<TEntity>> matrixMutipleChoiceQuestionBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new MatrixMultipleChoiceQuestionBuilder<TEntity>();
            matrixMutipleChoiceQuestionBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddMultipleText<TProperty>(Expression<Func<TEntity, TProperty>> expression, Action<MultipleTextQuestionBuilder<TEntity>> multipleTextQuestionBuilder)
        {
            TEntity mEntity = new TEntity();
            var myProperty = ReflectionHelpers.GetPropertyInfo(mEntity, expression);
            var builder = new MultipleTextQuestionBuilder<TEntity>();
            multipleTextQuestionBuilder.Invoke(builder);
            builder.HasName(myProperty.Name);
            elementsBuilder.Add(builder);
            return this;
        }

        public PageBuilder<TEntity> AddPanel(string name,Action<PanelBuilder<TEntity>> panelBuilder)
        {
            var builder = new PanelBuilder<TEntity>();
            panelBuilder.Invoke(builder);
            builder.HasName(name);
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