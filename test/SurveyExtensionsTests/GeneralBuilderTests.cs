using System;
using Xunit;

namespace SurveyExtensionsTests
{
    using Dtos;
    using FluentAssertions;
    using SurveyExtensions.Builders;
    using SurveyExtensions.Elements;

    public class GeneralBuilderTests
    {
        [Fact]
        public void TestSingleInput()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Pagina 1", 
                    page => 
                        page.AddSingleInput(x => x.DocumentId,
                                b => b
                                    .HasTitle("Dni")
                                    .HasPlaceHolder("Ponga aqui su dni")
                                    .SetInputType(SurveyInputType.Text))
                            .AddSingleInput(x=> x.ContactData,
                                b=> b
                                    .HasTitle("Datos de Contacto")
                                    .HasPlaceHolder("Ponga Aqui sus Datos de Contacto"))
                )
                .AddPage("Pagina 2", page=> 
                    page.AddSingleInput(x=> x.IsCashReceiptCriteria, b=> b.SetInputType(SurveyInputType.Email))
                );

            companyBuilder.AddPage("MiPaginaMolona",
                p => p.AddSingleInput(c => c.DocumentId, "placeholderMolon", "MiDni", SurveyInputType.Text));
                
            
            
            var myBuildedElements = companyBuilder.Build();
            myBuildedElements.Pages.Count.Should().Be(3);
        }

        [Fact]
        public void TestCheckBox()
        {
            SurveyBuilder<CompanyDto> companyBuilder = Factory.BulderFactory.Get_1Page_3Checkbox();

            var myBuildedElements = companyBuilder.Build();
            myBuildedElements.Pages.Count.Should().Be(1);
        }
    }
}
