namespace SurveyExtensionsTests.Factory
{
    using SurveyExtensions.Builders;
    using SurveyExtensions.Enums;
    using SurveyExtensionsTests.Dtos;


    public static class BulderFactory
    {
        public static void Get_1Page_CheckboxWithAllWithNoneSortedAscending
            (SurveyBuilder<CompanyDto> builder,string pageName)
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
                        .SetChoicesOrder(ChoicesOrderOprions.asc))
            );
        }

        public static void Get_1Page_CheckboxWithAllSortedDescending
            (SurveyBuilder<CompanyDto> builder, string pageName)
        {
            builder.AddPage(pageName,
                page =>page.AddCheckboxInput(x => x.ContactData,
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
                                    .SetChoicesOrder(ChoicesOrderOprions.desc))
            );
        }

        public static void Get_1Page_CheckboxWithNoneSortedRandom
            (SurveyBuilder<CompanyDto> builder, string pageName)
        {
            builder.AddPage(pageName,
                    page =>
                        page
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
                                    .SetChoicesOrder(ChoicesOrderOprions.random))
                );
        }

        public static void Get_1Page_RadiogroupAscending(SurveyBuilder<CompanyDto> builder,
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
                                    .SetChoicesOrder(ChoicesOrderOprions.asc))
                );
        }

        public static void Get_1Page_RadiogroupDescending(SurveyBuilder<CompanyDto> builder,
                                                                    string pageName)
        {
            builder.AddPage(pageName, 
                    page =>
                        page.AddRadiogroup(x => x.ContactData,
                                b => b
                                    .HasTitle("Radiogroup  2 Title (desc)")
                                    .AddChoice("RG2Val1", "Choice 1")
                                    .AddChoice("RG2Val2", "Choice 2")
                                    .AddChoice("RG2Val3", "Choice 3")
                                    .AddChoice("RG2Val4", "Choice 4")
                                    .AddChoice("RG2Val5", "Choice 5")
                                    .HasColumnCount(2))
                );
        }

        public static void Get_1Page_RadiogroupRandom(SurveyBuilder<CompanyDto> builder,
                                                             string pageName)
        {
            builder.AddPage(pageName,
                    page =>
                        page.AddRadiogroup(x => x.ContactData,
                                b => b
                                    .HasTitle("Radiogroup  3 Title (random)")
                                    .AddChoice("RG3Val1", "Choice 1")
                                    .AddChoice("RG3Val2", "Choice 2")
                                    .AddChoice("RG3Val3", "Choice 3")
                                    .AddChoice("RG3Val4", "Choice 4")
                                    .AddChoice("RG3Val5", "Choice 5")
                                    .HasColumnCount(3)
                                    .SetChoicesOrder(ChoicesOrderOprions.random))
                );
        }

        public static void Get_1Page_DropdownAscending(SurveyBuilder<CompanyDto> builder,
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
                                    .SetChoicesOrder(ChoicesOrderOprions.asc))
                );
        }

        public static void Get_1Page_DropdownDescending(SurveyBuilder<CompanyDto> builder,
                                                    string pageName)
        {
            builder.AddPage(pageName,
                    page =>
                        page.AddDropdown(x => x.ContactData,
                                b => b
                                    .HasTitle("Dropdown  2 Title (desc)")
                                    .HasDescription("Dropdown 2 description")
                                    .AddChoice("DD2Val1", "Choice 1")
                                    .AddChoice("DD2Val2", "Choice 2")
                                    .AddChoice("DD2Val3", "Choice 3")
                                    .AddChoice("DD2Val4", "Choice 4")
                                    .AddChoice("DD2Val5", "Choice 5")
                                    .SetChoicesOrder(ChoicesOrderOprions.desc))
                );
        }

        public static void Get_1Page_DropdownRandom(SurveyBuilder<CompanyDto> builder,
                                                    string pageName)
        {
            builder.AddPage(pageName,
                    page =>
                        page.AddDropdown(x => x.ContactData,
                                b => b
                                    .HasTitle("Dropdown  3 Title (random)")
                                    .HasDescription("Dropdown 3 description")
                                    .AddChoice("DD3Val1", "Choice 1")
                                    .AddChoice("DD3Val2", "Choice 2")
                                    .AddChoice("DD3Val3", "Choice 3")
                                    .AddChoice("DD3Val4", "Choice 4")
                                    .AddChoice("DD3Val5", "Choice 5")
                                    .SetChoicesOrder(ChoicesOrderOprions.random))
                );
        }

        public static void Get_1Page_ImagePickerAscending(SurveyBuilder<CompanyDto> builder,
                                                    string pageName)
        {
            builder.AddPage(pageName,
                    page =>
                        page.AddImagePickerInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Image Picker 1 Title (asc)")
                                    .AddChoice("IP1Val1", "Lion", "https://surveyjs.io/Content/Images/examples/image-picker/lion.jpg")
                                    .AddChoice("IP1Val2", "Giraffe", "https://surveyjs.io/Content/Images/examples/image-picker/giraffe.jpg")
                                    .AddChoice("IP1Val3", "Panda", "https://surveyjs.io/Content/Images/examples/image-picker/panda.jpg")
                                    .AddChoice("IP1Val4", "Camel", "https://surveyjs.io/Content/Images/examples/image-picker/camel.jpg")
                                    .HasColumnCount(0)
                                    .SetChoicesOrder(ChoicesOrderOprions.asc))
                );
        }

        public static void Get_1Page_ImagePickerDescending(SurveyBuilder<CompanyDto> builder,
                                            string pageName)
        {
            builder.AddPage(pageName,
                    page =>
                        page.AddImagePickerInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Image Picker 1 Title (asc)")
                                    .AddChoice("IP1Val1", "Lion", "https://surveyjs.io/Content/Images/examples/image-picker/lion.jpg")
                                    .AddChoice("IP1Val2", "Giraffe", "https://surveyjs.io/Content/Images/examples/image-picker/giraffe.jpg")
                                    .AddChoice("IP1Val3", "Panda", "https://surveyjs.io/Content/Images/examples/image-picker/panda.jpg")
                                    .AddChoice("IP1Val4", "Camel", "https://surveyjs.io/Content/Images/examples/image-picker/camel.jpg")
                                    .HasColumnCount(2)
                                    .SetChoicesOrder(ChoicesOrderOprions.desc))
                );
        }

        public static void Get_1Page_ImagePickerRandom(SurveyBuilder<CompanyDto> builder,
                                            string pageName)
        {
            builder.AddPage(pageName,
                    page =>
                        page.AddImagePickerInput(x => x.ContactData,
                                b => b
                                    .HasTitle("Image Picker 1 Title (asc)")
                                    .AddChoice("IP1Val1", "Lion", "https://surveyjs.io/Content/Images/examples/image-picker/lion.jpg")
                                    .AddChoice("IP1Val2", "Giraffe", "https://surveyjs.io/Content/Images/examples/image-picker/giraffe.jpg")
                                    .AddChoice("IP1Val3", "Panda", "https://surveyjs.io/Content/Images/examples/image-picker/panda.jpg")
                                    .AddChoice("IP1Val4", "Camel", "https://surveyjs.io/Content/Images/examples/image-picker/camel.jpg")
                                    .HasColumnCount(0)
                                    .SetChoicesOrder(ChoicesOrderOprions.random))
                );
        }
    }
}
