using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configuration


{
    public class ElementsQuickAnswers
    {
        //ListContent

        public string QuickAnswersModule = "quickAnswers";

        public string QuickAnswersView = "//div[@class='quickAnswers']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //Xpath
        public string TextQuickAnswersView = "QuickAnswers element view";

        public string QuickAnswersButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.quickAnswers #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string TextQuickAnswersButtonNew = "New QuickAnswers button";

        public string QuickAnswersFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.quickAnswers #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextQuickAnswersFieldSearch = "Field Search";

        public string QuickAnswersButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.quickAnswers #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextQuickAnswersButtonSearch = "Search button";

        public string QuickAnswersIconRemoved = "//div[@class='quickAnswers']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']"; //Xpath
        public string TextQuickAnswersIconRemoved = "Delete QuickAnswers icon";

        public string QuickAnswersTitleItemView = "//div[@id='itemField.Name']/div[2]/div/div/h3";


        //DetailContent


        public string QuickAnswersTab = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Quick";
        public string TextQuickAnswersTab = "Information tab";

        public string QuickAnswersInputName = ".container-app .container-module .admin .content.col.module .quickAnswers .details .tabContent.svGeneral input[name='Name']";
        public string TextQuickAnswersInputName = "Name";
                     
        public string QuickAnswersServicesSearch = ".ui-autocomplete";
        public string TextQuickAnswersServicesSearch = "Services search";

        public string QuickAnswersType = ".container-app .container-module .admin .content.col.module .quickAnswers .details .tabContent.svGeneral > div #Type";
        public string TextQuickAnswersType = "Type";

        public string QuickAnswersListType = "//*[@id='type']/ul/li/a";

        public string QuickAnswersDescription = ".container-app .container-module .admin .content.col.module .quickAnswers .details .tabContent.svGeneral textarea[name='Description']";
        public string TextQuickAnswersDescription = "Description";
                
        public string QuickAnswersState = "//div[@id='tabs-1']/div/form/div[3]/div/div/div[2]/label/div";
        public string TextQuickAnswersState = "Status switch";

        public string QuickAnswersSubmit = "div.quickAnswers > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";
        public string TextQuickAnswersSubmit = "Save Button";

        public string QuickAnswersCancel = "div.quickAnswers > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";
        public string TextQuickAnswersCancel = "Cancel Button";
    }
}
