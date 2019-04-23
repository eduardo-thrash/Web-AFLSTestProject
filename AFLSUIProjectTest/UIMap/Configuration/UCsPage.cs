namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ElementsUC
    {
        //Elements SubMenu y option
        public string UCModule = "UC";

        public string UCButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.uc #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string UCSubmit = "div.uc > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string UCFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.uc #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextUCFieldSearch = "Field Search";

        public string UCButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.uc #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextUCButtonSearch = "Button Search";

        public string UCView = "//div[@class='uc']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextUCView = "UC element view";

        public string UCIconRemoved = "//div[@class='uc']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextUCIconRemoved = "Delete UC icon";

        //Tab UC Details
        public string UCTabDetail = "//div[@class='uc']/div[2]/div/div/div/ul/li/a[@href='#tabs-1']"; //XPath

        public string TextTabUCDetail = "UC detail";

        public string UCName = ".container-app .container-module .admin .content.col.module .uc .details .tabContent.UCGeneral input[name='Name']";
        public string TextUCName = "name";

        public string UCDescription = ".container-app .container-module .admin .content.col.module .uc .details .tabContent.UCGeneral textarea[name='Description']";
        public string TextUCDescription = "Description";

        public string UCStartDate = ".container-app .container-module .admin .content.col.module .uc .details .tabContent.UCGeneral input#UCStartDate";
        public string TextUCStartDate = "Start date";

        public string UCFinishDate = ".container-app .container-module .admin .content.col.module .uc .details .tabContent.UCGeneral input#UCFinishDate";
        public string TextUCFinishDate = "Finish Date";

        public string UCCheckEndDate = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.uc > #rightsidebar > div > div.row.top > div > #tabs-1 > div > form > div.row.center > div.endDate.itemRow > div.itemField.check > div.value > div";
        public string TextCheckEndDate = "switch end date";

        public string UCLimitDaysFinishAlarm = "#UCLimitDaysFinishAlarm";
        public string TextLimitDaysFinishAlarm = "limit Finish Alarm";

        public string UCDateReview = "#UCDateReview";
        public string TextUCDateReview = "Date Review";

        public string UCCheckReviewDate = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.uc > #rightsidebar > div > div.row.top > div > #tabs-1 > div > form > div.row.center > div.reviewDate.itemRow.itemField > div.itemField.check > div.value > div";
        public string TextCheckReviewDate = "switch review date";

        public string UCLimitDaysReviewAlarm = "#UCLimitDaysReviewAlarm";
        public string TextLimitDaysReviewAlarm = "limit review Alarm";

        public string UCCost = ".container-app .container-module .admin .content.col.module .uc .details .tabContent.UCGeneral input[name='Cost']";
        public string TextCost = "cost";

        public string UCPenality = ".container-app .container-module .admin .content.col.module .uc .details .tabContent.UCGeneral input[name='Penality']";
        public string TextPenality = "Penality";

        /*Tab Acuerdos de tiempos*/
        public string UCTabTimeAgreements = "//div[@class='uc']/div[2]/div/div/div/ul/li/a[@href='#tabs-2']"; //XPath
        public string TextTabTimeAgreements = "Time Agreements";

        public string UCChronometerAutocomplete = "//div[@class='uc']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/div[@class='row top']/div/div[@class='value']/input[@id='chronometerAutocomplete']";
        public string TextChronometerAutocomplete = "UC chronometer";

        public string UCChronometerHours = "//div[@class='uc']//div[@id='tabs-2']//input[@name='Hours']";
        public string TextChronometerHours = "UC chronometer Hours";

        public string UCChronometerMinutes = "//div[@class='uc']//div[@id='tabs-2']//input[@name='Minutes']";
        public string TextChronometerMinutes = "UC chronometer Minutes";

        public string UCChronometerCompilance = "//div[@class='uc']//div[@id='tabs-2']//input[@name='Compilance']";
        public string TextChronometerCompilance = "UC chronometer Compilance";

        /*Tab Archivos adjuntos*/
        public string UCTabAttachedFiles = "//div[@class='uc']/div[2]/div/div/div/ul/li/a[@href='#tabs-3']";
        public string TextTabAttachedFiles = "Attached Files";

        public string UCStartCalendarControl = "/html/body/div[12]/div[1]/div[2]/table/tbody/tr/td";
        public string UCFinishCalendarControl = "/html/body/div[13]/div[1]/div[2]/table/tbody/tr/td";
        public string UCReviewCalendarControl = "/html/body/div[14]/div[1]/div[2]/table/tbody/tr/td";
    }
}