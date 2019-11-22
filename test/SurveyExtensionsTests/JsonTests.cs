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
        public void SingleTextInputTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Page1",
                p => p.AddSingleInput(c => c.DocumentId, "Put Here your DNI", "Document Id Card", SurveyInputType.Text)
                );

            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.test1);
        }

        [Fact]
        public void CommentTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Page1",
                p => p.AddCommentInput(c => c.ContactData, "Datos de contacto", "entra los datos de contacto", 7)
                      .AddCommentInput(c => c.ContactData,
                                i => i.HasTitle("Datos de contacto 2")
                                .HasPlaceHolder("placeholder 2")
                                .HasRows(14)
                                .ContinueInSameLine())
                      );

            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.test1);
        }

        [Fact]
        public void RatingTests()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Page1",
                p => p
                .AddRating(c => c.IsLegalPerson, "Rating with values", "", 1, 10, 1)
                .AddRating(c => c.IsLegalPerson,
                            i => i.HasTitle("Rating with options")
                                .AddRateValue("RTVal1", "Val 1")
                                .AddRateValue("RTVal2", "Val 2")
                                .AddRateValue("RTVal3", "Val 3")
                                .AddRateValue("RTVal4", "Val 4")
                                .AddRateValue("RTVal5", "Val 5")
                                .AddRateValue("RTVal6", "Val 6")
                                .AddRateValue("RTVal7", "Val 7")
                                .AddRateValue("RTVal8", "Val 8"))
                );

            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.test1);
        }

        [Fact]
        public void CheckboxWithAllWithNoneSortedAscendingTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_CheckboxWithAllWithNoneSortedAscending(companyBuilder, "Checkbox 1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.test1);
        }

        [Fact]
        public void CheckboxWithAllSortedDescendingTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_CheckboxWithAllSortedDescending(companyBuilder, "Checkbox 2");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.test1);
        }

        [Fact]
        public void CheckboxWithAllWithNoneSortedAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_CheckboxWithAllWithNoneSortedAscending(companyBuilder, "Checkbox 3");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.test1);
        }


    }
}
