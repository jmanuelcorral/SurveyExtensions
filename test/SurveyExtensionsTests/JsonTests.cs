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
            jsonextracted.Should().Be(jsoncollections.SingleInputTestExtractedJson);
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
            jsonextracted.Should().Be(jsoncollections.CommentTestExtractedJson);
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
            jsonextracted.Should().Be(jsoncollections.RatingTestExtractedJson);
        }

        [Fact]
        public void Checkbox1TestWithAllWithNoneSortedAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_CheckboxWithAllWithNoneSortedAscending(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.Checkbox1TestExtractedJson);
        }

        [Fact]
        public void Checkbox2TestWithAllSortedDescending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_CheckboxWithAllSortedDescending(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.Checkbox2TestExtractedJson);
        }

        [Fact]
        public void Checkbox3TestWithAllWithNoneSortedAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_CheckboxWithAllWithNoneSortedAscending(companyBuilder, "Checkbox 3");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.Checkbox3TestExtractedJson);
        }

        [Fact]
        public void Radiogroup1TestAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_RadiogroupAscending(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.Radiogroup1TestExtractedJson);
        }

        [Fact]
        public void Radiogroup2TestDescending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_RadiogroupDescending(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.Radiogroup2TestExtractedJson);
        }

        [Fact]
        public void Radiogroup3TestRandom()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_RadiogroupRandom(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.Radiogroup3TestExtractedJson);
        }

        [Fact]
        public void Dromdowm1TestAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_RadiogroupRandom(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.Dropdown1TestExtractedJson);
        }

        [Fact]
        public void Dromdowm2TestDescending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_DropdownDescending(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.Dropdown2TestExtractedJson);
        }

        [Fact]
        public void Dromdowm3TestRandom()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_DropdownRandom(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.Dropdown3TestExtractedJson);
        }

        [Fact]
        public void ImagePicker1TestAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_ImagePickerAscending(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.ImagePicker1TestExtractedResult);
        }

        [Fact]
        public void ImagePicker2TestDescending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_ImagePickerDescending(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.ImagePicker2TestExtractedResult);
        }

        [Fact]
        public void ImagePicker3TestRandom()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_ImagePickerRandom(companyBuilder, "Page1");
            var myBuildedElements = companyBuilder.Build();
            var jsonextracted = JsonConvert.SerializeObject(myBuildedElements, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
            jsonextracted.Should().Be(jsoncollections.ImagePicker3TestExtractedResult);
        }
    }
}
