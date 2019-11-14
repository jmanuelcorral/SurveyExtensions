namespace SurveyExtensions.Builders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Elements;

    public class SurveyBuilder<TEntity> where TEntity : new()
    {
        private readonly List<SurveyItemBuilder> _pageBuilders = new List<SurveyItemBuilder>();

       
        public SurveyBuilder<TEntity> AddPage(string pageName, Action<SurveyPageBuilder<TEntity>> pageBuilder)
        {
           var builder = new SurveyPageBuilder<TEntity>();
           pageBuilder.Invoke(builder);
           builder.HasName(pageName);
           _pageBuilders.Add(builder);
           return this;
        }

        public List<SurveyItem> Build()
        {
            return _pageBuilders.Select(x => x.Build()).ToList();
        }
    }

    
}