namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ServicesPage
    {
        //Elements SubMenu y option
        public string ServiceModule = "Services";

        public string ServiceButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.services #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string ServiceSubmit = "div.services > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";
        public string TextServiceButtonNew = "Nuevo";

        public string ServiceFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.services #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextServiceFieldSearch = "Field Search";

        public string ServiceButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.services #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextServiceButtonSearch = "Button Search";

        public string ServiceTitleItemView = "//div[@class='services']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //XPath

        public string ServiceView = "//div[@class='services']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextServiceView = "calendar element view";

        public string ServiceIconRemoved = "//div[@class='services']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";//XPath
        public string TextServiceIconRemoved = "Delete service icon";

        /*Tab Service*/
        public string ServiceTabService = "//div[@class='services']//a[@href='#tabs-1']";
        public string ServiceName = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral input[name='Name']";
        public string ServiceModel = "//div[@id='Model']/div/a";
        public string ServiceDescription = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral textarea[name='Description']";
        public string ServiceSubject = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral input[name='SubjectDefault']";
        public string ServiceCalendar = "//div[@class='services']//div[@id='Calendar']/div/a";
        public string ServiceSLA = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral > div #Sla";
        public string ServiceUC = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral > div #Uc";
        public string ServiceOLA = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral > div #Ola";
        public string ServiceType = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral > div #ServiceType";
        public string ServiceAssigmentType = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral > div #ProviderAssignmentType";

        public string ListModel = "//*[@id='Model']/ul/li/a";
        public string ListCalendar = "//*[@id='Calendar']/ul/li/a";
        public string ListSLA = "//*[@id='Sla']/ul/li/a";
        public string ListUC = "//*[@id='Uc']/ul/li/a";
        public string ListOLA = "//*[@id='Ola']/ul/li/a";
        public string ListType = "//*[@id='ServiceType']/ul/li/a";
        public string ListAssigmentType = "//*[@id='ProviderAssignmentType']/ul/li/a";

        public string TextServiceTabService = "Service";
        public string TextServiceName = "Name";
        public string TextServiceModel = "Model selector";
        public string TextServiceDescription = "description";
        public string TextServiceSubject = "Subject";
        public string TextServiceCalendar = "Calendar selector";
        public string TextServiceSLA = "SLA selector";
        public string TextServiceUC = "UC Selector";
        public string TextServiceOLA = "OLA Selector";
        public string TextServiceType = "Service type selector";
        public string TextServiceAssigmentType = "service assigment type selector";

        public string ServiceCost = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral input[name='BaseCost']";

        public string ServiceCheckIsDefault = "//div[@class='services']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row center-bottom']/div[6]/div[@class='two-column left IsDefault']/div/label/span";
        public string ServiceCheckIsPriorityOrEmergency = "//div[@class='services']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row center-bottom']/div[6]/div[@class='two-column right IsPriorityOrEmergency']/div/label/span";

        public string ServiceCheckCI = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral > div.innerTab.row > form.validate > div.row.center-bottom > div.clearfix > div.two-column.left.IsProvideAllCIs";

        public string TextServiceCost = "Cost";
        public string TextServiceCheckIsDefault = "default service check for customers";
        public string TextServiceCheckIsPriorityOrEmergency = "default emergency service check for orders";
        public string TextServiceCheckCI = "default service check for CI's";

        public string ServiceHours = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral input[name='ser_hours']";
        public string ServiceMinutes = ".container-app .container-module .admin .content.col.module .services .details .tabContent.svGeneral input[name='ser_mins']";

        public string TextServiceHours = "Service hours";
        public string TextServiceMinutes = "Service minutes";

        public string ServiceState = "//div[@class='services']//div[@id='tabs-1']//label[@class='onoffswitch-label']";

        /*Tab Inventory*/
        public string ServiceTabInventory = "//div[@class='services']//a[@href='#tabs-2']";
        public string ServiceInventorySearch = "//div[@class='services']//div[@id='tabs-2']//input[@class='partSearch ui-autocomplete-input']";

        public string TextServiceTabInventory = "Inventory tab";
        public string TextServiceInventorySearch = "inventory search";

        public string ServiceInventoryList = "//ul[@class='ui-autocomplete ui-front ui-menu ui-widget ui-widget-content ui-corner-all']/li/a[@class='ui-corner-all']";

        //Tab Service Skills
        public string ServiceTabSkills = "a[href = '#tabs-3'] > span.ui-icon.icon-skills.icons_Sv";

        public string ServiceInputSkillsSearch = "//div[@class='services']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-3']/div/div[@class='row top searcher']/div/div[@class='block itemRow partName']/form/div/input";

        public string TextServiceTabSkills = "Skills tab";
        public string TextServiceInputSkillsSearch = "Skills search";//Cambiar por TextServiceInputSkillsSearch

        public string ServiceTitleSkillName;
        public string ServiceSwitchSkillMandatory;
        public string ServiceButtonSkillLevel;
        public string ServiceButtonSkillRemoved;

        public string TextServiceTitleSkillName = "Skill name";
        public string TextServiceSwitchSkillMandatory = "Skill mandatory";
        public string TextServiceButtonSkillLevel = "Skill level";
        public string TextServiceButtonSkillRemoved = "Skill removed";

        public string ServiceSkillList = "//ul[@class='ui-autocomplete ui-front ui-menu ui-widget ui-widget-content ui-corner-all']/li/a[@class='ui-corner-all']";

        public string ServiceMediumLevel = "//*label[@for='mid-4']";
        //"//ul[@class='ui-autocomplete ui-front ui-menu ui-widget ui-widget-content ui-corner-all']/li/a[class='ui-corner-all']"

        /*Tab providers*/
        public string ServiceTabProviders = "a[href = '#tabs-4'] > span.ui-icon.icon-providers.icons_Sv";
        public string ServiceProvidersSearch = "#tabs-4 > div.innerTab.row > div.row.top.searcher > div.container > div.block.itemRow.partName > div.value > input.partSearch.ui-autocomplete-input";

        public string ServiceProviderList = "//ul[@class='ui-autocomplete ui-front ui-menu ui-widget ui-widget-content ui-corner-all']/li/a[@class='ui-corner-all']";

        public string ServiceProviderAgreement = "//div[@id='tabs-4']/div/div[@class='row bottom list']/div/div/div/div[@class='itemView']/div/div[@class='row ans']/div[@class='value']/div[@id='Sla']/div/a";

        public string TextServiceProviderAgreement = "Agreement selector by provider";
        public string ServiceProviderAgreementList = "//div[3]/div[2]/div/ul/li/a";

        /*Tab Task*/
        public string ServiceTabTasks = "a[href = '#tabs-5'] > span.ui-icon.icon-task.icons_Sv";
        public string ServiceTasksSearch = "//input[@id='nameTask']";

        public string TextServiceTabTasks = "Task tab";
        public string TextServiceTasksSearch = "Task search";

        public string ServiceButtonTaskAdd = "//input[@id='addTask']";

        /*Tan Additional Fields*/
        public string ServiceTabAdditionalFields = "a[href = '#tabs-6']";
        public string TextServiceTabAdditionalFields = "Additional Fields tab";

        public string ServiceAdditionalFieldInputDefault = "//div[@id='tabs-6']/div/div/div/div/div/input";
    }
}