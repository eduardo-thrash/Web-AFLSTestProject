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

        #endregion

        #region Assigment Section

        public string AutomaticAssigmentTab = "//div[@class='workOrder contentWO']//div[@id='tabs-2']/div[@class='assignment-tabs']/label[@for='autoTab']";
        public string ManualAssigmentTab = "//div[@class='workOrder contentWO']//div[@id='tabs-2']/div[@class='assignment-tabs']/label[@for='manualTab']";
        public string ManualSpecialistFilter = "//div[@class='workOrder contentWO']//div[@id='tabs-2']//input[@class='filterBtn']";

        #endregion
    }
}