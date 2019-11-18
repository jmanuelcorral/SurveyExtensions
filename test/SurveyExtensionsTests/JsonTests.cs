namespace SurveyExtensionsTests
{
    using System;
    using Xunit;
    using SurveyExtensionsTests.Dtos;
    using FluentAssertions;
    using SurveyExtensionsTests.jsonResults;
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

            companyBuilder.AddPage("Page1",
                p => p.AddSingleInput(c => c.DocumentId, "Put Here your DNI", "Document Id Card", SurveyInputType.Text)
                .AddCommentInput(c => c.ContactData, "Datos de contacto", "entra los datos de contacto", 7)
                .AddCommentInput(c => c.ContactData, 
                                i => i.HasTitle("Datos de contacto 2")
                                .HasPlaceHolder("placeholder 2")
                                .HasRows(14)
                                .ContinueInSameLine())
                .AddRating(c=>c.IsLegalPerson, "Rating with values", "", 1, 10, 1)
                .AddRating(c => c.IsLegalPerson,
                            i=> i.HasTitle("Rating with options")
                                .AddRateValue("RTVal1", "Val 1")
                                .AddRateValue("RTVal2", "Val 2")
                                .AddRateValue("RTVal3", "Val 3")
                                .AddRateValue("RTVal4", "Val 4")
                                .AddRateValue("RTVal5", "Val 5")
                                .AddRateValue("RTVal6", "Val 6")
                                .AddRateValue("RTVal7", "Val 7")
                                .AddRateValue("RTVal8", "Val 8"))
                );

            Factory.BulderFactory.Get_1Page_3Checkbox(companyBuilder, "Checkbox Page");
            Factory.BulderFactory.Get_1Page_3Radiogroup(companyBuilder, "Radiogroup Page");
            Factory.BulderFactory.Get_1Page_3Dropdown(companyBuilder, "Dropdown Page");

            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.test1);
        }
    }
}
