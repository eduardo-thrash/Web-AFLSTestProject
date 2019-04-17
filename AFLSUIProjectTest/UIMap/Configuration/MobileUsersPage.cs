namespace AFLSUIProjectTest.UIMap
{
    public class MobileUsersPage
    {
        //Elements SubMenu y option
        public string MobileUsersModulePath = "//div[contains(@class, 'icon iconsAd usersWeb')]";

        public string MobileUserModule = "Mobile Users";
        public string MobileUserButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.users #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string MobileUserSubmit = "div.users > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string MobileUserFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.users #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextMobileUserFieldSearch = "Field Search";

        public string MobileUserButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.users #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextMobileUserButtonSearch = "Button Search";

        public string MobileUserView = "//div[@class='users']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextMobileUserView = "client usersMobile view";

        public string MobileUserIconRemoved = "//div[@class='users']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextMobileUserIconRemoved = "Delete usersMobile icon";

        public string MobileUserTabInfo = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Usr";
        public string MobileUserName = ".container-app .container-module .admin .content.col.module .users .details .tabContent.svGeneral input[name='Name']";
        public string MobileUserUserName = ".container-app .container-module .admin .content.col.module .users .details .tabContent.svGeneral input[name='UserName']";
        public string MobileUserEmail = ".container-app .container-module .admin .content.col.module .users .details .tabContent.svGeneral input[name='Email']";
        public string MobileUserPhone = ".container-app .container-module .admin .content.col.module .users .details .tabContent.svGeneral input[name='Phone']";
        public string MobileUserPassword = ".container-app .container-module .admin .content.col.module .users .details .tabContent.svGeneral input[name='Password']";
        public string MobileUserPosition = "//div[@class='users']//div[@id='tabs-1']//a[@class='dd-selected']";
        public string MobileUserPositionOption = "//div[@class='users']//div[@id='tabs-1']//div[@id='Position']//a[@class='dd-option']";

        public string MobileUserAddress = "#usersAddress";
        public string MobileUserLocation = "//div[@class='users']//div[@id='location']//a[@class='dd-selected']";
        public string MobileUserLocationOption = "//div[@class='users']//div[@id='location']//a[@class='dd-option']";
        public string MobileUserTransport = "//div[@class='users']//div[@id='Transport']//a[@class='dd-selected']";

        public string MobileUserTransportOption = "//*[@id='Transport']/ul/li/a/input";
        public string MobileUserProvider = "//div[@class='users']//div[@id='Provider']//a[@class='dd-selected']";
        public string MobileUserProviderOption = "//div[@class='users']//div[@id='Provider']//a[@class='dd-option']";

        public string TextMobileUserTabInfo = "Tab Information";
        public string TextMobileUserName = "Name";
        public string TextMobileUserUserName = "Username";
        public string TextMobileUserEmail = "Email";
        public string TextMobileUserPhone = "Phone";
        public string TextMobileUserPassword = "Password";
        public string TextMobileUserPosition = "Position";
        public string TextMobileUserAddress = "Address";
        public string TextMobileUserLocation = "Location";
        public string TextMobileUserTransport = "Transport";
        public string TextMobileUserProvider = "Provider";

        public string TabMobileUserMobileGroups = "a[href = '#tabs-3'] > span.ui-icon.icon-group.icons_Usr";
        public string MobileUserMobileGroups = "//div[@class='users']//div[@id='tabs-3']//input[@class='partSearch ui-autocomplete-input']";

        public string MobileUserMobileGroupsOption = "//li/a[@class='ui-corner-all']";

        public string TextTabMobileUserMobileGroups = "Tab mobile groups";
        public string TextMobileUserMobileGroups = "group";

        public string TabMobileUserAvilibily = "a[href = '#tabs-4'] > span.ui-icon.icon-time.icons_Usr";
        public string MobileUserAvailabiltty = "#calendar > div > div > table > tbody > tr > td > div > div > div.fc-slats > table > tbody > tr:nth-child(8) > td:nth-child(2)";

        public string TextTabMobileUserAvailabilty = "Tab Availability";
        public string TextMobileUserAvailabilty = "Availabiltty";

        public string MobileUserState = "//div[@class='users']//div[@id='tabs-1']//label[@class='onoffswitch-label']";

        public string MobileUserLinkMail = /*"//div[@id='users']//div[@id='tabs-1']*/"//div[@class='sendEmail']/span[@class='msg']";

        //Tab Mobile User Skills
        public string TabMobileUserSkills = "a[href = '#tabs-5'] > span.ui-icon.icon-skills.icons_Usr"; //cambiar por MobileUserTabSkills

        public string MobileUserSkill = "//div[@id='tabs-5']//input[@class='partSearch ui-autocomplete-input']";
        public string MobileUserSkillOption = "//li/a[@class='ui-corner-all']";

        public string ServiceTitleSkillName;
        public string ServiceButtonSkillLevel;
        public string ServiceButtonSkillRemoved;

        public string TextMobileUserTabSkills = "Skill tab";
        public string TextMobileUserInputSkillSearch = "Skill search";
        public string TextServiceTitleSkillName = "Skill name";
        public string TextServiceButtonSkillLevel = "Skill level";
        public string TextServiceButtonSkillRemoved = "Skill removed";

        #region Availabiltty

        public string AvailabilttyBlock = "//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']//td//a[@class='fc-time-grid-event fc-v-event fc-event fc-start fc-end fc-draggable fc-resizable']";
        public string AvailabilttyBlockInherited = "//div[@class='users']//div[@id='tabs-4']//div[@id='calendar']//td//a[@class='fc-time-grid-event fc-v-event fc-event fc-start fc-end inherited fc-resizable']";

        public string GroupCardView = "//div[@class='users']//div[@id='tabs-3']//div[@class='itemView']//div[@class='block Name value']";

        #endregion
    }
}