namespace SurveyExtensionsTests
{
    using Xunit;
    using SurveyExtensionsTests.Dtos;
    using FluentAssertions;
    using SurveyExtensionsTests.jsonResults;
    using SurveyExtensions.Builders;
    using SurveyExtensions.Enums;

    public class JsonTests
    {
        [Fact]
        public void SingleTextInputTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Page1",
                p => p.AddSingleInputQuestion(c => c.DocumentId, 
                    i => i.HasPlaceHolder("Put Here your DNI")
                        .HasTitle("Document Id Card")
                        .SetInputType(SingleInputTypes.Text))
                );

            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.SingleInputTestExtractedJson);
        }

        [Fact]
        public void CommentTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Page1",
                p => p.AddCommentInput(c => c.ContactData, 
                                i => i.HasTitle("Datos de contacto")
                                .HasPlaceHolder("entra los datos de contacto")
                                .HasRows(7))
                      .AddCommentInput(c => c.ContactData,
                                i => i.HasTitle("Datos de contacto 2")
                                .HasPlaceHolder("placeholder 2")
                                .HasRows(14)
                                .ContinueInSameLine())
                      );

            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.CommentTestExtractedJson);
        }

        [Fact]
        public void RatingTests()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Page1",
                p => p
                .AddRating(c => c.IsLegalPerson, 
                            i => i.HasTitle("Rating with values")
                                 .HasRateMin(1)
                                 .HasRateMax(10)
                                 .HasRateStep(1))
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

            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.RatingTestExtractedJson);
        }

        [Fact]
        public void Checkbox1TestWithAllWithNoneSortedAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_CheckboxWithAllWithNoneSortedAscending(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.Checkbox1TestExtractedJson);
        }

        [Fact]
        public void Checkbox2TestWithAllSortedDescending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_CheckboxWithAllSortedDescending(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.Checkbox2TestExtractedJson);
        }

        [Fact]
        public void Checkbox3TestWithAllWithNoneSortedAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_CheckboxWithAllWithNoneSortedAscending(companyBuilder, "Checkbox 3");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.Checkbox3TestExtractedJson);
        }

        [Fact]
        public void Radiogroup1TestAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_RadiogroupAscending(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.Radiogroup1TestExtractedJson);
        }

        [Fact]
        public void Radiogroup2TestDescending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_RadiogroupDescending(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.Radiogroup2TestExtractedJson);
        }

        [Fact]
        public void Radiogroup3TestRandom()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_RadiogroupRandom(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.Radiogroup3TestExtractedJson);
        }

        [Fact]
        public void Dromdowm1TestAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_DropdownAscending(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.Dropdown1TestExtractedJson);
        }

        [Fact]
        public void Dromdowm2TestDescending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_DropdownDescending(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.Dropdown2TestExtractedJson);
        }

        [Fact]
        public void Dromdowm3TestRandom()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_DropdownRandom(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.Dropdown3TestExtractedJson);
        }

        [Fact]
        public void ImagePicker1TestAscending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_ImagePickerAscending(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.ImagePicker1TestExtractedJson);
        }

        [Fact]
        public void ImagePicker2TestDescending()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_ImagePickerDescending(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.ImagePicker2TestExtractedJson);
        }

        [Fact]
        public void ImagePicker3TestRandom()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            Factory.BulderFactory.Get_1Page_ImagePickerRandom(companyBuilder, "Page1");
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.ImagePicker3TestExtractedJson);
        }

        [Fact]
        public void BooleanTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            companyBuilder.AddPage("Page1",
                p => p.AddBooleanInput(c => c.IsLegalPerson,
                l => l.HasLabel("Boolean label")
                      .HasLabelTrue("True")
                      .HasLabelFalse("False")
                     ));
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.BooleanTestExtractedJson);
        }

        [Fact]
        public void HtmlEditornTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            companyBuilder.AddPage("Page1",
                p => p.AddHtmlEditor(c => c.ContactData,
                l => l.HasHtml("<h1>H1 content</h1><p>Paragraph</p>")
                     ));
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.HtmlEditorTestExtractedJson);
        }

        [Fact]
        public void FileTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            companyBuilder.AddPage("Page1",
                p => p.AddFile(c => c.ContactData,
                l => l.HasMaxSize(250)
                     ));
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.FileExtractedJson);
        }

        [Fact]
        public void MatrixSingleChoiceTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            companyBuilder.AddPage("Page1",
                p => p.AddMatrixSingleChoice(c => c.ContactData,
                m => m.HasTitle("MSC Title")
                      .HasDescription("MSC DEscription")
                      .AddColumn("0", "Bad")
                      .AddColumn("1", "Mid-Bad")
                      .AddColumn("2", "Mid")
                      .AddColumn("3", "Mid-Good")
                      .AddColumn("4", "Good")
                      .AddRow("R0", "Superman")
                      .AddRow("R1", "Batman")
                      .AddRow("R2", "Spiderman")
                      .AddRow("R3", "Jocker")
                      .SetIsAllRowRequired()
                     ));
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.MatrixSingleChoiceExtractedJson);
        }

        [Fact]
        public void MatrixMultipleChoiceTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            companyBuilder.AddPage("Page1",
                p => p.AddMatrixMutipleChoice(c => c.ContactData,
                m => m.HasTitle("MSC Title")
                      .HasDescription("MSC DEscription")
                      .AddColumn("0", "Bad")
                      .AddColumn("1", "Mid-Bad", CellTypes.Boolean)
                      .AddColumn("2", "Mid", CellTypes.Checkbox)
                      .AddColumn("3", "Mid-Good", CellTypes.Comment)
                      .AddColumn("4", "Good", CellTypes.Dropdown)
                      .AddColumn("5", "Excellent", CellTypes.Radiogroup)
                      .AddColumn("6", "SuperPower", CellTypes.Text)
                      .AddRow("R0", "Superman")
                      .AddRow("R1", "Batman")
                      .AddRow("R2", "Spiderman")
                      .AddRow("R3", "Jocker")
                      .AddChoice("C1", "Choice 1")
                      .AddChoice("C2", "Chice 2")
                      .HasCellType(CellTypes.Dropdown)
                     ));
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.MatrixMultipleChoiceExtractedJson);
        }

        [Fact]
        public void MultipleText()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            companyBuilder.AddPage("Page1",
                p => p.AddMultipleText(c => c.ContactData,
                l => l.AddItem("Item 1 text")
                      .AddItem("Item 2 text")
                      .AddItem("Item 3 text")
                      .AddItem("Item 4 text")
                      .HasColumnCount(2)
                     ));
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.MultipleTextTestExtractedJson);
        }

        [Fact]
        public void PanelWithelementsTest()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();
            companyBuilder.AddPage("Page1",
                p => p.AddPanel("Panel1", pn => pn.AddFile( i=> i.ContactData, f=>f.HasMaxSize(50))));
            var builtCompany = companyBuilder.Build();
            var extractedJson = builtCompany.ToJson();
            extractedJson.Should().Be(jsoncollections.PanelWithElementsExtractedJson);
        }
    }
}
