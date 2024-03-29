﻿namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyInputItemBuilder<TEntity> :
        SurveyItemBuilderBase<TEntity, SurveyInputItem>,
        IBuilder<SurveyItem> where TEntity : new()
    {
        public SurveyInputItemBuilder()
        {
            _item.Type = "text";
            _item.InputType = "text";
        }

        public SurveyInputItemBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }

        public SurveyInputItemBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public SurveyInputItemBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public SurveyInputItemBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public SurveyInputItemBuilder<TEntity> IsNotRequired()
        {
            _item.IsRequired = false;
            return this;
        }

        public SurveyInputItemBuilder<TEntity> IsVisible()
        {
            _item.IsVisible = true;
            return this;
        }

        public SurveyInputItemBuilder<TEntity> IsNotVisible()
        {
            _item.IsVisible = false;
            return this;
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
    }
}