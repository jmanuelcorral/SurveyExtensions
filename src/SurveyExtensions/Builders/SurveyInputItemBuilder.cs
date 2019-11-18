namespace SurveyExtensions.Builders
{
    using System;
    using Elements;

    public class SurveyInputItemBuilder<TEntity> :
        SurveyItemBuilderBase<TEntity, SurveyInputItem, SurveyInputItemBuilder<TEntity>>,
        IBuilder<SurveyItem> where TEntity : new()
    {
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