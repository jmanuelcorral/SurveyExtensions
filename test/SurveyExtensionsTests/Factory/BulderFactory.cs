﻿namespace SurveyExtensionsTests.Factory
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
                        page.AddRadiogroup(x => x.ContactData,
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
                        .AddRadiogroup(x => x.ContactData,
                                b => b
                                    .HasTitle("Radiogroup  2 Title (desc)")
                                    .AddChoice("RG2Val1", "Choice 1")
                                    .AddChoice("RG2Val2", "Choice 2")
                                    .AddChoice("RG2Val3", "Choice 3")
                                    .AddChoice("RG2Val4", "Choice 4")
                                    .AddChoice("RG2Val5", "Choice 5")
                                    .HasColumnCount(2))
                        .AddRadiogroup(x => x.ContactData,
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

        public static void Get_1Page_3Dropdown(SurveyBuilder<CompanyDto> builder,
                                                            string pageName)
        {
            builder.AddPage(pageName,
                    page =>
                        page.AddDropdown(x => x.ContactData,
                                b => b
                                    .HasTitle("Dropdown 1 Title (asc)")
                                    .HasDescription("Dropdown 1 description")
                                    .AddChoice("DD1Val1", "Choice 1")
                                    .AddChoice("DD1Val2", "Choice 2")
                                    .AddChoice("DD1Val3", "Choice 3")
                                    .AddChoice("DD1Val4", "Choice 4")
                                    .AddChoice("DD1Val5", "Choice 5")
                                    .HasOtherChoice("Other choice text")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.asc))
                        .AddDropdown(x => x.ContactData,
                                b => b
                                    .HasTitle("Dropdown  2 Title (desc)")
                                    .HasDescription("Dropdown 2 description")
                                    .AddChoice("DD2Val1", "Choice 1")
                                    .AddChoice("DD2Val2", "Choice 2")
                                    .AddChoice("DD2Val3", "Choice 3")
                                    .AddChoice("DD2Val4", "Choice 4")
                                    .AddChoice("DD2Val5", "Choice 5")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.desc))
                        .AddDropdown(x => x.ContactData,
                                b => b
                                    .HasTitle("Dropdown  3 Title (random)")
                                    .HasDescription("Dropdown 3 description")
                                    .AddChoice("DD3Val1", "Choice 1")
                                    .AddChoice("DD3Val2", "Choice 2")
                                    .AddChoice("DD3Val3", "Choice 3")
                                    .AddChoice("DD3Val4", "Choice 4")
                                    .AddChoice("DD3Val5", "Choice 5")
                                    .SetChoicesOrder(SurveyChoicesOrderEnum.random))
                );
        }
    }
}
