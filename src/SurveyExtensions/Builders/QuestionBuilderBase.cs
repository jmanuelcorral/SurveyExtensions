namespace SurveyExtensions.Builders
{
    using System;
    using Elements;
    using SurveyExtensions.Elements.Questions;

    public abstract class QuestionBuilderBase<TEntity, TQuestion> : IBuilder<SurveyItem> 
        where TEntity : new()
        where TQuestion : SurveyQuestion
    {
        protected TQuestion _item = (TQuestion)(Activator.CreateInstance(typeof(TQuestion)));

        public SurveyItem Build()
        {
            return _item;
        }
    }
}