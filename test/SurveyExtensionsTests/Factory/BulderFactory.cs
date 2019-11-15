namespace SurveyExtensionsTests.Factory
{
    using SurveyExtensions.Builders;
    using SurveyExtensions.Elements;
    using SurveyExtensionsTests.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Text;


    public static class BulderFactory
    {
        public static SurveyBuilder<CompanyDto> Get_1Page_3Checkbox()
        {
            SurveyBuilder<CompanyDto> companyBuilder = new SurveyBuilder<CompanyDto>();

            companyBuilder.AddPage("Pagina 1",
                    page =>
                        page.AddCheckboxInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Choice 1 Title (asc) - All - None")
                                    .AddChoide("CB1Val1", "Choice 1")
                                    .AddChoide("CB1Val2", "Choice 2")
                                    .AddChoide("CB1Val3", "Choice 3")
                                    .AddChoide("CB1Val4", "Choice 4")
                                    .AddChoide("CB1Val5", "Choice 5")
                                    .HasColumnCount(1)
                                    .HasOtherChoide("Other choice text")
                                    .HasSelectAllChoide("Select All")
                                    .HasSelectNoneChoide("Select none")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.asc))
                        .AddCheckboxInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Choice 2 Title (desc) - All")
                                    .AddChoide("CB2Val1", "Choice 1")
                                    .AddChoide("CB2Val2", "Choice 2")
                                    .AddChoide("CB2Val3", "Choice 3")
                                    .AddChoide("CB2Val4", "Choice 4")
                                    .AddChoide("CB2Val5", "Choice 5")
                                    .HasColumnCount(2)
                                    .HasOtherChoide("Other choice text")
                                    .HasSelectAllChoide("Select All")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.desc))
                        .AddCheckboxInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Choice 3 Title (random) - None")
                                    .AddChoide("CB3Val1", "Choice 1")
                                    .AddChoide("CB3Val2", "Choice 2")
                                    .AddChoide("CB3Val3", "Choice 3")
                                    .AddChoide("CB3Val4", "Choice 4")
                                    .AddChoide("CB3Val5", "Choice 5")
                                    .HasColumnCount(3)
                                    .HasOtherChoide("Other choice text")
                                    .HasSelectNoneChoide("Select none")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.random))
                );
            return companyBuilder;
        }
    }
}
