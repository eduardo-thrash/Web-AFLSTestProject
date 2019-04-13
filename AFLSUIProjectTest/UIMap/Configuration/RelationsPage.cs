using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.ConfigurationMenuServiceCatalogue
{
    public class RelationsPage
    {
        //ListContent

        public string RelationModule = "Relations";

        public string RelationView = "//div[@class='relations']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //Xpath
        public string TextRelationView = "relation element view";

        public string RelationButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.relations #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        
        public string TextRelationButtonNew = "New relation button";

        public string RelationFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.relations #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextRelationFieldSearch = "Field Search";

        public string RelationButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.relations #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextRelationButtonSearch = "Search button";

        public string RelationIconRemoved = "//div[@class='relations']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']"; //Xpath
        public string TextRelationIconRemoved = "Delete relation icon";

        public string RelationTitleItemView = "//div[@id='itemField.Name']/div[2]/div/div/h3";


        //DetailContent


        public string RelationTab = "a[href = '#tabs-1'] > span.ui-icon.icon-relationship.icons_Relations";
        public string TextRelationTab = "Information tab";

        public string RelationInputName = ".container-app .container-module .admin .content.col.module .relations .details .tabContent.relationship input[name='Name']";
        public string TextRelationInputName = "Name";

        public string RelationButtonLink = "//div[@id='relationTypeId_link']/div/form/div/div[2]/div[3]/label";//Xpath
        public string TextRelationButtonLink = "Link button";

        public string RelationButtonSuccession = "//div[@id='relationTypeId_sucession']/div/form/div/div[2]/div[3]/label";//Xpath
        public string TextRelationButtonSuccession = "Succession button";

        public string RelationButtonOrders = "//div[@id='relationTypeId_workOrder']/div/form/div/div[2]/div[3]/label";//Xpath
        public string TextRelationButtonOrders = "Orders button";

        public string RelationButtonCIs = "//div[@id='relationSourceOriginId_ci']/div/form/div/div[2]/div[3]/label";//Xpath
        public string TextRelationButtonCIs = "CIs button";

        public string RelationInputSource = ".container-app .container-module .admin .content.col.module .relations .details .tabContent.relationship input[name='SourceName']";
        public string TextRelationInputSource = "Source Name";

        public string RelationInputTarget = ".container-app .container-module .admin .content.col.module .relations .details .tabContent.relationship input[name='TargetName']";
        public string TextRelationInputTarget = "Target Name";

        public string RelationState = "//div[@id='tabs-1']/div/form/div[3]/div/div/div[2]/label/div";
        public string TextRelationState = "Status switch";

        public string RelationSubmit = "div.relations > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";
        public string TextRelationSubmit = "Save Button";

        public string RelationCancel = "div.relations > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";
        public string TextRelationCancel = "Cancel Button";
    }
}
