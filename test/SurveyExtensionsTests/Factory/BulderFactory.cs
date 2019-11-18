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
        public static void Get_1Page_3Checkbox(SurveyBuilder<CompanyDto> builder,
                                                                    string pageName)
        {
            builder.AddPage(pageName,
                    page =>
                        page.AddCheckboxInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Choice 1 Title (asc) - All - None")
                                    .AddChoice("CB1Val1", "Choice 1")
                                    .AddChoice("CB1Val2", "Choice 2")
                                    .AddChoice("CB1Val3", "Choice 3")
                                    .AddChoice("CB1Val4", "Choice 4")
                                    .AddChoice("CB1Val5", "Choice 5")
                                    .HasColumnCount(1)
                                    .HasOtherChoice("Other choice text")
                                    .HasSelectAllChoice("Select All")
                                    .HasSelectNoneChoice("Select none")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.asc))
                        .AddCheckboxInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Choice 2 Title (desc) - All")
                                    .AddChoice("CB2Val1", "Choice 1")
                                    .AddChoice("CB2Val2", "Choice 2")
                                    .AddChoice("CB2Val3", "Choice 3")
                                    .AddChoice("CB2Val4", "Choice 4")
                                    .AddChoice("CB2Val5", "Choice 5")
                                    .HasColumnCount(2)
                                    .HasOtherChoice("Other choice text")
                                    .HasSelectAllChoice("Select All")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.desc))
                        .AddCheckboxInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Choice 3 Title (random) - None")
                                    .AddChoice("CB3Val1", "Choice 1")
                                    .AddChoice("CB3Val2", "Choice 2")
                                    .AddChoice("CB3Val3", "Choice 3")
                                    .AddChoice("CB3Val4", "Choice 4")
                                    .AddChoice("CB3Val5", "Choice 5")
                                    .HasColumnCount(3)
                                    .HasOtherChoice("Other choice text")
                                    .HasSelectNoneChoice("Select none")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.random))
                );
        }

        public static void Get_1Page_3Radiogroup(SurveyBuilder<CompanyDto> builder,
                                                                    string pageName)
        {
            builder.AddPage(pageName, 
                    page =>
                        page.AddRadiogroupInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Radiogroup 1 Title (asc)")
                                    .AddChoice("RG1Val1", "Choice 1")
                                    .AddChoice("RG1Val2", "Choice 2")
                                    .AddChoice("RG1Val3", "Choice 3")
                                    .AddChoice("RG1Val4", "Choice 4")
                                    .AddChoice("RG1Val5", "Choice 5")
                                    .HasColumnCount(1)
                                    .HasOtherChoice("Other choice text")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.asc))
                        .AddRadiogroupInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Radiogroup  2 Title (desc)")
                                    .AddChoice("RG2Val1", "Choice 1")
                                    .AddChoice("RG2Val2", "Choice 2")
                                    .AddChoice("RG2Val3", "Choice 3")
                                    .AddChoice("RG2Val4", "Choice 4")
                                    .AddChoice("RG2Val5", "Choice 5")
                                    .HasColumnCount(2))
                        .AddRadiogroupInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Radiogroup  3 Title (random)")
                                    .AddChoice("RG3Val1", "Choice 1")
                                    .AddChoice("RG3Val2", "Choice 2")
                                    .AddChoice("RG3Val3", "Choice 3")
                                    .AddChoice("RG3Val4", "Choice 4")
                                    .AddChoice("RG3Val5", "Choice 5")
                                    .HasColumnCount(3)
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.random))
                );
        }
    }
}
