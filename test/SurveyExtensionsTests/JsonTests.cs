using System;
using Xunit;

namespace SurveyExtensionsTests
{
    using Dtos;
    using FluentAssertions;
    using jsonResults;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using SurveyExtensions.Builders;
    using SurveyExtensions.Elements;

    public class JsonTests
    {
        [Fact]
        public void TestSerialization()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Page1",p => p.AddSingleInput(c => c.DocumentId, "Put Here your DNI", "Document Id Card", SurveyInputType.Text));
           
            
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.test1);
        }
    }
}
