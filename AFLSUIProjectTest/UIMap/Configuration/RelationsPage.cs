namespace AFLSUIProjectTest.UIMap.ConfigurationMenuServiceCatalogue
{
    public class RelationsPage
    {
        //ListContent

        public string RelationModule = "Relations";

        public string RelationView = "//div[@class='relations']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //Xpath
        public string TextRelationView = "relation element view";

        public string RelationViewNoFound = "//div[@class='mCSB_container mCS_y_hidden mCS_no_scrollbar_y']/div/div";

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

        public string RelationButtonLink = "//div[@class='relations']//label[@for='relationTypeId_link']";//Xpath
        public string TextRelationButtonLink = "Link button";

        public string RelationButtonSuccession = "//div[@class='relations']//label[@for='relationTypeId_sucession']";//Xpath

        public string RelationButtonOrders = "//div[@id='relationTypeId_workOrder']/div/form/div/div[2]/div[3]/label";//Xpath

        public string RelationButtonCIs = "//div[@id='relationSourceOriginId_ci']/div/form/div/div[2]/div[3]/label";//Xpath

        public string RelationInputSource = ".container-app .container-module .admin .content.col.module .relations .details .tabContent.relationship input[name='SourceName']";

        public string RelationInputTarget = ".container-app .container-module .admin .content.col.module .relations .details .tabContent.relationship input[name='TargetName']";

        public string RelationState = "//div[@class='relations']//div[@id='tabs-1']//label[@class='onoffswitch-label']";

        public string RelationSubmit = "div.relations > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string RelationCancel = "div.relations > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";
    }
}