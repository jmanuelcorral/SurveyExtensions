namespace SurveyExtensions.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Elements;

    public class SurveyBuilder<TEntity> where TEntity : new()
    {
        private readonly Survey survey = new Survey();
        private readonly List<PageBuilder<TEntity>> _pageBuilders = new List<PageBuilder<TEntity>>();

       
        public SurveyBuilder<TEntity> AddPage(string pageName, Action<PageBuilder<TEntity>> pageBuilder)
        {
           var builder = new PageBuilder<TEntity>();
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