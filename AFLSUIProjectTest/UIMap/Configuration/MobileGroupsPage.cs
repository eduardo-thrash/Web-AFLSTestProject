using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap
{
    class ElementsMobileGroup
    {
        //Elements SubMenu y option
        public string MobileGroupsModulePath = "//div[contains(@class, 'icon iconsAd groupsWeb')]";
        
        public string MobileGroupModule = "Mobile Groups";
        public string MobileGroupButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.groupsMovil #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string MobileGroupSubmit = "div.groupsMovil > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string MobileGroupFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.groupsMovil #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextMobileGroupFieldSearch = "Field Search";

        public string MobileGroupButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.groupsMovil #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextMobileGroupButtonSearch = "Button Search";

        public string MobileGroupView = "//div[@class='groupsMovil']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextMobileGroupView = "client groups Movil view";

        public string MobileGroupIconRemoved = "//div[@class='groupsMovil']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextMobileGroupIconRemoved = "Delete groups Movil icon";

        //Tab Groups mobile
        public string MobileGroupsTabMobileGroups = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Grp";
        public string MobileGroupsName = ".container-app .container-module .admin .content.col.module .groupsMovil .details .tabContent.svGeneral input[name='Name']";
        public string MobileGroupsDescription = ".container-app .container-module .admin .content.col.module .groupsMovil .details .tabContent.svGeneral textarea[name='Description']";
        public string MobileGroupsProvider = "#Provider > div.dd-select > a.dd-selected";

        public string TextMobileGroupsTabMobileGroups = "Mobile Groups tab";
        public string TextMobileGroupsName = "Name";
        public string TextMobileGroupsDescription = "Description";
        public string TextMobileGroupsProvider = "provider selector";

        //Tab Users
        public string MobileGroupsTabUsers = "a[href = '#tabs-3'] > span.ui-icon.icon-users.icons_Grp";
        public string MobileGroupsUsers = "input[name ='Specs']";

        public string TextMobileGroupsTabUsers = "Users tab";
        public string TextMobileGroupsUsers = "auto-complete user selector";

        //Tab Skills
        public string MobileGroupsTabSkills = "a[href = '#tabs-4'] > span.ui-icon.icon-skills.icons_Grp";
        public string MobileGroupsSkill = "input[name='Skills']";

        public string TextMobileGroupsTabSkills = "Skill tab";
        public string TextMobileGroupsSkill = "auto-complete skill selector";

        //Tab Availability
        public string MobileGroupsTabAvailability = "a[href = '#tabs-5'] > span.ui-icon.icon-Availability.icons_Grp";
        public string MobileGroupsAvailability = "//div[@class='groupsMovil']/div[@id='rightsidebar']/div[@class='content']/div[@class='row top']/div/div[@id='tabs-5']/div/div[2]/div/div/div/table/tbody/tr/td/div/div/div[2]/table/tbody/tr[8]/td[@class='fc-widget-content']";

        public string TextMobileGroupsTabAvailability = "Availability Tab";
        public string TextMobileGroupsAvailability = "Availability block";
    }
}
