namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ProvidersPage
    {
        public string ProviderModule = "Providers";

        public string ProviderFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.providers #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextProviderFieldSearch = "Field Search";

        public string ProviderButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.providers #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextProviderButtonSearch = "Button Search";

        public string ProviderButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.providers #content > div.center.header.row > div > div.btnSearch #commonNewItem";

        public string ProviderView = "//div[@class='providers']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //Xpath
        public string TextProviderView = "Provider element view";

        public string ProviderIconRemoved = "//div[@class='providers']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']"; //Xpath
        public string TextProviderIconRemoved = "Delete Provider icon";

        /*Tab Providers*/
        public string ProviderTabProviders = "a[href = '#tabs-1'] > span.ui-icon.icon-providers.icons_Cln"; //CssSelector
        public string ProviderName = "//div[@id='tabs-1']/div/form/div/div/div[2]/input";    //Xpath
        public string ProviderDescription = "//div[@id='tabs-1']/div/form/div/div[2]/div[2]/textarea"; //Xpath
        public string ProviderCheckIntern = "//*[@for='internalProvider']"; //Xpath
        public string ProviderCheckExtern = "//*[@for='externalProvider']"; //Xpath
        public string ProviderCheckAssignManual = "//*[@for='AssignManual']"; //Xpath
        public string ProviderCheckAssignBest = "//*[@for='AssignBest']"; //Xpath

        public string ProviderRadioHighPriority = "//*[@for='highImportance']"; //Xpath
        public string ProviderRadioMediumPriority = "//*[@for='mediumImportance']"; //Xpath
        public string ProviderRadioLowPriority = "//*[@for='lowImportance']"; //Xpath

        public string TextProviderTabProviders = "Tab providers";
        public string TextProviderName = "name";
        public string TextProviderDescription = "description";
        public string TextProviderCheckIntern = "Intern provider check";
        public string TextProviderCheckExtern = "Extern provider check";
        public string TextProviderCheckAssignManual = "Manual Assign";
        public string TextProviderCheckAssignBest = "Best specialist assign";

        public string ProviderState = "//div[@class='providers']//div[@id='tabs-1']//label[@class='onoffswitch-label']";

        /*Tab Services*/
        public string ProviderTabServices = "a[href = '#tabs-2'] > span.ui-icon.icon-services.icons_Cln"; //CssSelector
        public string ProviderServices = "input.partSearch.ui-autocomplete-input";
        public string TextProviderTabServices = "Tab services";
        public string TextProviderServices = "services";

        public string ProviderServiceSearch = "//div[@class='providers']//div[@id='tabs-2']//input[@class='partSearch ui-autocomplete-input']";
        public string ProviderServiceList = "//ul[@class='ui-autocomplete ui-front ui-menu ui-widget ui-widget-content ui-corner-all']/li/a[@class='ui-corner-all']";

        public string ProviderServiceAgreement = "//div[@id='tabs-2']/div/div[@class='row bottom list']/div/div/div/div[@class='itemView']/div/div[@class='row ans']/div[@class='value']/div[@id='Sla']/div/a";
        public string TextProviderServiceAgreement = "Agreement selector by service";

        public string ProviderServiceAgreementList = "//div[@id='tabs-2']/div/div['row bottom list']/div/div/div/div[@class='itemView']/div/div[2]/div[2]/div/ul/li/a";

        /*Tab Zones*/
        public string ProviderTabZones = "a[href = '#tabs-3'] > span.ui-icon.icon-zones.icons_Cln"; //CssSelector
        public string ProviderZones = "#tabs-3 > div > div.row.top.searcher > div > div.block.itemRow.partName > div > input";
        public string TextProviderTabZones = "Tab zones";
        public string TextProviderZones = "Zones";

        public string ProviderZoneSearch = "//div[@class='providers']//div[@id='tabs-3']//input[@class='partSearch ui-autocomplete-input']";
        public string ProviderZoneList = "//ul[@class='ui-autocomplete ui-front ui-menu ui-widget ui-widget-content ui-corner-all']/li/a[@class='ui-corner-all']";

        /*Tab Specialist*/
        public string ProviderTabSpecialist = "a[href = '#tabs-4'] > span.ui-icon.icon-specialists.icons_Cln"; //CssSelector
        public string TextProviderTabSpecialist = "Tab Specialist";

        /*Tab Monitors*/
        public string ProviderTabMonitors = "a[href = '#tabs-5'] > span.ui-icon.icon-monitors.icons_Cln"; //CssSelector
        public string ProviderMonitors = "#tabs-5 > div.innerTab.row > div.row.top.searcher > div.container > div.block.itemRow.partName > div.value.pos-relative > input.partSearch.ui-autocomplete-input";
        public string TextProviderTabMonitors = "Tab Monitors";
        public string TextProviderMonitors = "Monitors";

        public string ProviderMonitorSearch = "input.partSearch.ui-autocomplete-input";
        public string ProviderMonitorList = "//ul[@class='ui-autocomplete ui-front ui-menu ui-widget ui-widget-content ui-corner-all']/li/a[@class='ui-corner-all']";

        public string ProviderSubmit = "//div[@class='providers']//input[@id='btnSave']";// "div.providers > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave"; //CssSelector
    }
}