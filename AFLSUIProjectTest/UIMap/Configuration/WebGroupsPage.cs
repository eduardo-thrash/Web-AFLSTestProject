namespace AFLSUIProjectTest.UIMap
{
    internal class WebGroupsPage
    {
        //Elements SubMenu y option
        public string WebGroupsModulePath = "//div[contains(@class, 'icon iconsAd groupsWeb')]";

        public string WebGroupModule = "Web Groups";
        public string WebGroupButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.groupsWeb #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string WebGroupSubmit = "div.groupsWeb > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string WebGroupFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.groupsWeb #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextWebGroupFieldSearch = "Field Search";

        public string WebGroupButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.groupsWeb #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextWebGroupButtonSearch = "Button Search";

        public string WebGroupView = "//div[@class='groupsWeb']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextWebGroupView = "client groupsWeb view";

        public string WebGroupIconRemoved = "//div[@class='groupsWeb']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextWebGroupIconRemoved = "Delete groupsWeb icon";

        //Tab Groups web
        public string WebGroupTabWebGroup = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Grp";

        public string WebGroupName = ".container-app .container-module .admin .content.col.module .groupsWeb .details .tabContent.svGeneral input[name='Name']";
        public string WebGroupDescription = ".container-app .container-module .admin .content.col.module .groupsWeb .details .tabContent.svGeneral textarea[name='Description']";
        public string WebGroupCheckRoleAdministrator = ".container-app .container-module .admin .content.col.module .groupsWeb .details .tabContent.svGeneral label[for='Administrator']";
        public string WebGroupCheckRoleMonitor = ".container-app .container-module .admin .content.col.module .groupsWeb .details .tabContent.svGeneral label[for='AFLS_Monitor']";
        public string WebGroupCheckRoleDispatcher = ".container-app .container-module .admin .content.col.module .groupsWeb .details .tabContent.svGeneral label[for='AFLS_Dispatcher']";
        public string WebGroupCheckRoleInventory = ".container-app .container-module .admin .content.col.module .groupsWeb .details .tabContent.svGeneral label[for='AFLS_Inventory']";

        public string TextWebGroupTabWebGroup = "Tab Web group";
        public string TextWebGroupName = "Name";
        public string TextWebGroupDescription = "Description";
        public string TextWebGroupCheckRoleAdministrator = "Role Administrator";
        public string TextWebGroupCheckRoleMonitor = "Role Monitor";
        public string TextWebGroupCheckRoleDispatcher = "Role Dispatcher";
        public string TextWebGroupCheckRoleInventory = "Role Inventory";

        //Tab Users
        public string WebGroupTabUsers = "a[href = '#tabs-3'] > span.ui-icon.icon-users.icons_Grp";

        public string WebGroupUsers = "input._specSearch.specSearch.ui-autocomplete-input";

        public string TextWebGroupTabUsers = "Tab users";
        public string TextWebGroupUsers = "Users";
    }
}