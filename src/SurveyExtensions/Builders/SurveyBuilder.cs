namespace SurveyExtensions.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Elements;

    public class SurveyBuilder<TEntity> where TEntity : new()
    {
        private readonly Survey survey = new Survey();
        private readonly List<SurveyPageBuilder<TEntity>> _pageBuilders = new List<SurveyPageBuilder<TEntity>>();

       
        public SurveyBuilder<TEntity> AddPage(string pageName, Action<SurveyPageBuilder<TEntity>> pageBuilder)
        {
           var builder = new SurveyPageBuilder<TEntity>();
           pageBuilder.Invoke(builder);
           builder.HasName(pageName);
           _pageBuilders.Add(builder);
           return this;
        }

        public Survey Build()
        {

            survey.Pages.AddRange(_pageBuilders.Select(x => x.Build()).ToList());
            return survey;
        }
    }

    
}