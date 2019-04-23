namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class SLAsPage
    {
        //Elements SubMenu y option
        public string SLAModule = "SLA";

        public string SLAFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.sla #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextSLAFieldSearch = "Field Search";

        public string SLAButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.sla #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextSLAButtonSearch = "Button Search";

        public string SLAView = "//div[@class='sla']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextSLAView = "SLA element view";

        public string SLAIconRemoved = "//div[@class='sla']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextSLAIconRemoved = "Delete SLA icon";

        public string SLAButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.sla #content > div.center.header.row > div > div.btnSearch #commonNewItem";

        //Tab SLA details
        public string TabSLADetail = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div #rightsidebar > div > div.row.top > div > ul > li.ui-state-default.ui-corner-top.ui-tabs-active.ui-state-active #ui-id-1";

        public string TextTabSLADetail = "SLA detail";

        public string SLAName = ".container-app .container-module .admin .content.col.module .sla .details .tabContent.SLAGeneral input[name='Name']";
        public string TextSLAName = "name";

        public string SLADescription = ".container-app .container-module .admin .content.col.module .sla .details .tabContent.SLAGeneral textarea[name='Description']";
        public string TextSLADescription = "Description";

        public string SLAStartDate = "SLAStartDate";
        public string TextSLAStartDate = "Start date";

        public string SLAFinishDate = "SLAFinishDate";
        public string TextSLAFinishDate = "Finish Date";

        public string CheckEndDate = "#tabs-1 > div > form > div.row.center > div.endDate.itemRow > div.itemField.check > div.value > div > label";
        public string TextCheckEndDate = "switch end date";

        public string LimitDaysFinishAlarm = "#SLALimitDaysFinishAlarm";
        public string TextLimitDaysFinishAlarm = "limit Finish Alarm";

        public string SLADateReview = "SLADateReview";
        public string TextSLADateReview = "Date Review";

        public string CheckReviewDate = "#tabs-1 > div > form > div.row.center > div.reviewDate.itemRow.itemField > div.itemField.check > div.value > div";
        public string TextCheckReviewDate = "switch review date";

        public string LimitDaysReviewAlarm = "#SLALimitDaysReviewAlarm";
        public string TextLimitDaysReviewAlarm = "limit review Alarm";

        public string Cost = "Cost";
        public string TextCost = "cost";

        public string Penality = "Penality";
        public string TextPenality = "Penality";

        /*Elements Tab Acuerdos de tiempos*/
        public string TabTimeAgreements = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div #rightsidebar > div > div.row.top > div > ul > li:nth-child(2) #ui-id-2";
        public string TextTabTimeAgreements = "Time Agreements";

        public string ChronometerAutocomplete = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div #rightsidebar > div > div.row.top > div #tabs-2 > div > div.row.top > div > div.value #chronometerAutocomplete";
        public string TextChronometerAutocomplete = "SLA chronometer";

        public string ChronometerHours = "Hours";
        public string TextChronometerHours = "SLA chronometer Hours";

        public string ChronometerMinutes = "Minutes";
        public string TextChronometerMinutes = "SLA chronometer Minutes";

        public string ChronometerCompilance = "Compilance";
        public string TextChronometerCompilance = "SLA chronometer Compilance";

        /*Elements Tab Archivos adjuntos*/
        public string TabAttachedFiles = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div #rightsidebar > div > div.row.top > div > ul > li:nth-child(3) #ui-id-3";
        public string TextTabAttachedFiles = "Attached Files";

        public string SLASubmit = "div.sla > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string SLAStartCalendarControl = "/html/body/div[15]/div[1]/div[2]/table/tbody/tr/td";

        public string SLAFinishCalendarControl = "/html/body/div[16]/div[1]/div[2]/table/tbody/tr/td";

        public string SLAReviewCalendarControl = "/html/body/div[17]/div[1]/div[2]/table/tbody/tr/td";
    }
}