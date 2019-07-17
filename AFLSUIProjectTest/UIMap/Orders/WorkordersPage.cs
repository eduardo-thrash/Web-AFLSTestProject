using OpenQA.Selenium;

namespace AFLSUIProjectTest.UIMap.Orders
{
    public class WorkordersPage
    {
        #region Common

        private static string WOContent = "//div[@class='workOrder contentWO']";

        private static string FormNew = "//div[@class='col panel left header new']";

        #endregion Common

        public string ClientName = WOContent + FormNew + "//input[@name='clientName']";

        public string ContactName = WOContent + FormNew + "//input[@name='ContactName']";
        public string ContactPhone = WOContent + FormNew + "//input[@name='ContactPhone']";
        public string ContactEmail = WOContent + FormNew + "//input[@name='ContactEmail']";
        public string Address = WOContent + FormNew + "//input[@id='address']";
        public string AddressEndPoint = WOContent + FormNew + "//input[@id='addressEndPoint']";
        public string AddlAddressInfo = WOContent + FormNew + "//input[@name='AddlAddressInfo']";
        public string EndAddlAddressInfo = WOContent + FormNew + "//input[@name='EndAddlAddressInfo']";
        public string ServiceName = WOContent + FormNew + "//input[@name='ServiceName']";

        public string OptionOrderNormal = WOContent + FormNew + "//div[@data-action='normal']";
        public string OptionOrderEmergency = WOContent + FormNew + "//div[@data-action='emergency']";

        public string OptionOrderPriority = WOContent + FormNew + "//div[@data-action='priority']";

        public string Subject = WOContent + FormNew + "//input[@name='Subject']";

        public string Description = WOContent + FormNew + "//div[@class='contentEditable']";

        public string Save = "//div[@class='workOrder contentWO']//button[@id='btnSave']";

        public string Exit = WOContent + FormNew + "//div[@data-action='normal']";

        #region Tabs

        public string AssigmentTab = "//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-2']";
        public string AdditionalFieldTab = "//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-9']";
        public string RelationTab = "//div[@class='workOrder contentWO']//div[@class='jcarousel']//a[@href='#tabs-13']";

        #endregion

        #region Assigment Section

        public string AutomaticAssigmentTab = "//div[@class='workOrder contentWO']//div[@id='tabs-2']/div[@class='assignment-tabs']/label[@for='autoTab']";
        public string ManualAssigmentTab = "//div[@class='workOrder contentWO']//div[@id='tabs-2']/div[@class='assignment-tabs']/label[@for='manualTab']";
        public string RestrictionAssigmentTab = "//div[@class='workOrder contentWO']//div[@id='tabs-2']/div[@class='assignment-tabs']/label[@for='restrictionTab']";

        public string ManualSpecialistFilter = "//div[@class='workOrder contentWO']//div[@id='tabs-2']//input[@class='filterBtn']";
        public static By ManualSpecialistCard = By.XPath("//div[@class='list-box']//div[@class='itemContainer']");

        public static By CheckProviderRestriction = By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-2']//div[@class='criteria-box']//label[@for='woProvCheck']");
        public static By ProviderRestrictionList = By.XPath("//div[@id='provRestrictionSelect']//a[@class='dd-selected']");
        public static By CheckSpecialistRestriction = By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-2']//div[@class='criteria-box']//label[@for='woSpecialistCheck']");
        public static By SpecialistRestrictionList = By.XPath("//div[@class='criteria-element']//input[@name='SpecialistSearch']");
        public static By CheckStartDateRestriction = By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-2']//div[@class='criteria-box']//label[@for='woDateStartCheck']");
        public static By StartDateRestrictionControl = By.XPath("//div[@class='criteria-element']//input[@name='restrictionDate']");
        public static By CheckTimeofDayRestriction = By.XPath("//div[@class='workOrder contentWO']//div[@id='tabs-2']//div[@class='criteria-box']//label[@for='woTimeofDayCheck']");
        public static string CheckTimeofDayRestrictionString = "//div[@class='workOrder contentWO']//div[@id='tabs-2']//div[@class='criteria-box']//label[@for='woTimeofDayCheck']";

        public static By TimeofDayRestrictionMorning = By.XPath("//div[@id='tabs-2']//div[@class='criteria-element']//label[@for='_1']");
        public static By TimeofDayRestrictionAfternoon = By.XPath("//div[@id='tabs-2']//div[@class='criteria-element']//label[@for='_2']");
        public static By TimeofDayRestrictionNight = By.XPath("//div[@id='tabs-2']//div[@class='criteria-element']//label[@for='_3']");

        #endregion

        #region relation Section

        public string RelationNew = "//div[@class='workOrder contentWO']//div[@id='tabs-13']//input[@id='btnAdd']";
        public string RelationType = "//div[@class='workOrder contentWO']//div[@id='tabs-13']//div[@id='Relation']/div/a[@class='dd-selected']";
        public string RelationOptionsType = "//div[@id='Relation']/ul/li/a/label[@class='dd-option-text']";

        public string RelationOrder = "//div[@class='workOrder contentWO']//div[@id='tabs-13']//div[@class='row inputSearch']/input[@class='_searchOrder searchOrder ui-autocomplete-input']";

        #endregion
    }
}