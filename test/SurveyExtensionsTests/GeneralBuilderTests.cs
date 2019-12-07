namespace SurveyExtensionsTests
{
    using System;
    using Xunit;
    using SurveyExtensionsTests.Dtos;
    using FluentAssertions;
    using SurveyExtensions.Builders;
    using SurveyExtensions.Elements;
    using SurveyExtensions.Enums;

    public class GeneralBuilderTests
    {
        [Fact]
        public void TestSingleInput()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Pagina 1", 
                    page => 
                        page.AddSingleInputQuestion(x => x.DocumentId,
                                b => b
                                    .HasTitle("Dni")
                                    .HasPlaceHolder("Ponga aqui su dni")
                                    .SetInputType(SingleInputTypes.Text))
                            .AddSingleInputQuestion(x=> x.ContactData,
                                b=> b
                                    .HasTitle("Datos de Contacto")
                                    .HasPlaceHolder("Ponga Aqui sus Datos de Contacto"))
                )
                .AddPage("Pagina 2", page=> 
                    page.AddSingleInputQuestion(x=> x.IsCashReceiptCriteria, b=> b.SetInputType(SingleInputTypes.Email))
                );

            companyBuilder.AddPage("MiPaginaMolona",
                p => p.AddSingleInputQuestion(c => c.DocumentId, 
                    i => i.HasPlaceHolder("placeholderMolon")
                         .HasTitle("MiDni")
                         .SetInputType(SingleInputTypes.Text)));
                
            
            
            var myBuildedElements = companyBuilder.Build();
            myBuildedElements.Pages.Count.Should().Be(3);
        }

    }
}
