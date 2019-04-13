using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ElementsOLA
    {
        //Elements SubMenu y option
        public string OLAModule = "UC";
        public string OLAButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.ola #content > div.center.header.row > div > div.btnSearch #commonNewItem"; //CssSelector
        public string OLASubmit = "div.ola > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave"; //CssSelector

        public string OLAFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.ola #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextOLAFieldSearch = "Field Search";

        public string OLAButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.ola #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextOLAButtonSearch = "Button Search";

        public string OLAView = "//div[@class='ola']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextOLAView = "OLA element view";

        public string OLAIconRemoved = "//div[@class='ola']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextOLAIconRemoved = "Delete OLA icon";

        //Tab UC Details
        public string OLATabDetail = "//div[@class='ola']/div[2]/div/div/div/ul/li/a[@href='#tabs-1']"; //XPath
        public string TextOLATabDetail = "OLA detail";

        public string OLAName = ".container-app .container-module .admin .content.col.module .ola .details .tabContent.OLAGeneral input[name='Name']"; //CssSelector
        public string TextOLAName = "name";

        public string OLADescription = ".container-app .container-module .admin .content.col.module .ola .details .tabContent.OLAGeneral textarea[name='Description']"; //CssSelector
        public string TextOLADescription = "Description";

        public string OLAStartDate = ".container-app .container-module .admin .content.col.module .ola .details .tabContent.OLAGeneral input#OLAStartDate"; //CssSelector
        public string TextOLAStartDate = "Start Date";

        public string OLAFinishDate = ".container-app .container-module .admin .content.col.module .ola .details .tabContent.OLAGeneral input#OLAFinishDate"; //CssSelector
        public string TextOLAFinishDate = "Finish Date";

        public string OLACheckEndDate = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.ola > #rightsidebar > div > div.row.top > div > #tabs-1 > div > form > div.row.center > div.endDate.itemRow > div.itemField.check > div.value > div"; //CssSelector
        public string TextOLACheckEndDate = "Switch end date";

        public string OLALimitDaysFinishAlarm = "#OLALimitDaysFinishAlarm"; //CssSelector
        public string TextOLALimitDaysFinishAlarm = "Limit Days FinishAlarm";

        public string OLADateReview = "#OLADateReview"; //CssSelector
        public string TextOLADateReview = "Date Review";

        public string OLACheckReviewDate = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.ola > #rightsidebar > div > div.row.top > div > #tabs-1 > div > form > div.row.center > div.reviewDate.itemRow.itemField > div.itemField.check > div.value > div"; //CssSelector
        public string TextOLACheckReviewDate = "Switch Review Date";

        public string OLALimitDaysReviewAlarm = "#OLALimitDaysReviewAlarm"; //CssSelector
        public string TextOLALimitDaysReviewAlarm = "Limit Days Review Alarm";

        public string OLACost = ".container-app .container-module .admin .content.col.module .ola .details .tabContent.OLAGeneral input[name='Cost']"; //CssSelector
        public string TextOLACost = "Cost"; 

        public string OLAPenality = ".container-app .container-module .admin .content.col.module .ola .details .tabContent.OLAGeneral input[name='Penality']"; //CssSelector
        public string TextOLAPenality = "Penality";

        /*Tab Acuerdos de tiempos*/
        public string OLATabTimeAgreements = "//div[@class='ola']/div[2]/div/div/div/ul/li/a[@href='#tabs-2']"; //XPath
        public string TextTabTimeAgreements = "Time Agreements";

        public string OLAChronometerAutocomplete = "//div[@class='ola']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div/div[@class='row top']/div/div[@class='value']/input[@id='chronometerAutocomplete']";

        public string TextChronometerAutocomplete = "OLA chronometer";

        public string OLAChronometerHours = "//div[@class='ola']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-2']/div[@class='innerTab row']/div[2]/div[@id='mCSB_6']/div[@id='mCSB_6_container']/div[2]/div/div/div[2]/div/form/div[4]/input[@name='Hours']";
        public string TextChronometerHours = "OLA chronometer Hours";

        public string OLAChronometerMinutes = "(//input[@name='Minutes'])";
        public string TextChronometerMinutes = "OLA chronometer Minutes";

        public string OLAChronometerCompilance = "(//input[@name='Compilance'])";
        public string TextChronometerCompilance = "OLA chronometer Compilance";

        /*Tab Archivos adjuntos*/
        public string OLATabAttachedFiles = "//div[@class='ola']/div[2]/div/div/div/ul/li/a[@href='#tabs-3']";
        public string TextOLATabAttachedFiles = "Attached Files";
    }
}
