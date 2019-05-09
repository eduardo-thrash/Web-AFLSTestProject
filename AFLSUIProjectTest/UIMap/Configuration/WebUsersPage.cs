namespace AFLSUIProjectTest.UIMap
{
    public class WebUsersPage
    {
        //Elements SubMenu y option
        public string WebUsersModulePath = "//div[contains(@class, 'icon iconsAd usersWeb')]";

        public string WebUserModule = "Web Users";
        public string WebUserButtonNew = "//div[@class='usersWeb']//input[@id='commonNewItem']";
        public string WebUserSubmit = "div.usersWeb > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string WebUserFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.usersWeb #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextWebUserFieldSearch = "Field Search";

        public string WebUserButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.usersWeb #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextWebUserButtonSearch = "Button Search";

        public string WebUserView = "//div[@class='usersWeb']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextWebUserView = "client usersWeb view";

        public string WebUserIconRemoved = "//div[@class='usersWeb']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextWebUserIconRemoved = "Delete usersWeb icon";

        //Tab InfoUserWeb
        public string WebUserTabUserInfo = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Usr";

        public string WebUserName = ".container-app .container-module .admin .content.col.module .usersWeb .details .tabContent.svGeneral input[name='Name']";
        public string WebUserUserName = ".container-app .container-module .admin .content.col.module .usersWeb .details .tabContent.svGeneral input[name='UserName']";
        public string WebUserEmail = ".container-app .container-module .admin .content.col.module .usersWeb .details .tabContent.svGeneral input[name='Email']";
        public string WebUserPhone = ".container-app .container-module .admin .content.col.module .usersWeb .details .tabContent.svGeneral input[name='Phone']";
        public string WebUserPassword = ".container-app .container-module .admin .content.col.module .usersWeb .details .tabContent.svGeneral input[name='Password']";
        public string WebUserCheckAdministrator = ".container-app .container-module .admin .content.col.module .usersWeb .details .tabContent.svGeneral label[for='Administrator']";
        public string WebUserCheckMonitor = ".container-app .container-module .admin .content.col.module .usersWeb .details .tabContent.svGeneral label[for='AFLS_Monitor']";
        public string WebUserCheckDispatcher = ".container-app .container-module .admin .content.col.module .usersWeb .details .tabContent.svGeneral label[for='AFLS_Dispatcher']";
        public string WebUserCheckInventory = ".container-app .container-module .admin .content.col.module .usersWeb .details .tabContent.svGeneral label[for='AFLS_Inventory']";

        public string TextWebUserTabUserInfo = "Tab User information";
        public string TextWebUserName = "Name";
        public string TextWebUserUserName = "Username";
        public string TextWebUserEmail = "Email";
        public string TextWebUserPhone = "Phone";
        public string TextWebUserPassword = "Password";
        public string TextWebUserCheckAdministrator = "Check role administrator";
        public string TextWebUserCheckMonitor = "Check role monitor";
        public string TextWebUserCheckDispatcher = "Check role dispatcher";
        public string TextWebUserCheckInventory = "Check role inventory";

        //Tab Groups web
        public string WebUserTabWebGroups = "a[href = '#tabs-3'] > span.ui-icon.icon-group.icons_Usr";

        public string WebUserGroupWeb = "input.partSearch.ui-autocomplete-input";

        public string TextWebUserTabWebGroups = "Tab Web groups";
        public string TextWebUserGroupWeb = "users web";
    }
}