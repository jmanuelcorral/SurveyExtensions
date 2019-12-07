namespace SurveyExtensions.Elements
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.Collections.Generic;

    public class Survey
    {
        public List<SurveyPage> Pages { get; set; } = new List<SurveyPage>();

        public string ToJson() => JsonConvert.SerializeObject(this, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
    }
}