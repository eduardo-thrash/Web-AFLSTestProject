namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ClientsPage
    {
        public string ClientModule = "Clients";

        public string ClientFieldSearch = "//div[@class='clients']//div[@class='searchBox ']//input[@id='inputSearch']";
        public string TextCalendarFieldSearch = "Field Search";

        public string ClientButtonSearch = "//div[@class='clients']//div[@class='searchBox ']//button[@id='commonSearchItem']";
        public string TextClientButtonSearch = "Button Search";

        public string ClientButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.clients #content > div.center.header.row > div > div.btnSearch #commonNewItem";

        public string ClientView = "//div[@class='clients']//div[@class='itemView selected']//span[@class='nameLabelInfo']";
        public string TextClientView = "client element view";

        public string ClientIconRemoved = "//div[@class='clients']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextClientIconRemoved = "Delete client icon";

        /*Tab Client*/
        public string ClientTabClient = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Cln";
        public string ClientName2 = "(//input[@name='Name'])[2]";
        public string ClientName = "//div[@class='clients']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div/div[@class='name itemRow itemField']/div[2]/input[@name='Name']";
        public string ClientName3 = "#tabs-1 > div > form > div.row.top > div.name.itemRow.itemField > div.value.valid > input[name='Name']";
        public string ClientName4 = "//*[@id='tabs-1']/div/form/div[1]/div[1]/div[2]/input";
        public string ClientUniqueReference = "//div[@class='clients']//input[@name='UniqueReference']";
        public string ClientPhone = "//div[@class='clients']//input[@name='Phone']";
        public string ClientEmail = "//div[@class='clients']//input[@name='Email']";
        public string ClientComapny = "//div[@class='clients']//input[@name='CompanyName']";
        public string ClientAddress = "#clientAddress";
        public string ClientAddressValidate = "//div[@class='clients']//div[@id='tabs-1']//div[@id='clientAddresCheck']";
        public string ClientAddressDetail = "input[name = 'AddlAddressInfo']";

        public string ClientState = "//div[@class='clients']//div[@id='tabs-1']//label[@class='onoffswitch-label']";

        public string TextClientTabClient = "Client tab";
        public string TextClientName = "Name";
        public string TextClientUniqueReference = "UniqueReference";
        public string TextClientPhone = "Phone";
        public string TextClientEmail = "Email";
        public string TextClientComapny = "CompanyName";
        public string TextClientAddress = "Address";

        public string TextClientAddressDetail = "AddlAddressInfo";

        /*Tab Services*/
        public string ClientTabServices = "a[href = '#tabs-3'] > span.ui-icon.icon-time.icons_Cln";
        public string ClientServices = "//div[@class='clients']//div[@id='tabs-3']//input[@class='partSearch ui-autocomplete-input']";
        public string AutocompleteClientServices = "//ul/li/a[@class='ui-corner-all']";

        public string TextClientTabServices = "Client services tab";
        public string TextClientServices = "client services";

        /*Client Signature*/
        public string ClientTabSignature = "a[href = '#tabs-4'] > span.ui-icon.icon-signature.icons_Cln";
        public string ClientSignature = "#file";

        public string TextClientTabSignature = "Signature tab";
        public string TextClientSignature = "signature field";

        /*Additional fields*/
        public string ClientTabAdditionalFields = "a[href = '#tabs-6'] > span.ui-icon.icon-group.icon-additionalfields.icons_Cln";
        public string TextClientTabAdditionalFields = "Additional Fields Tab";

        /*Chanels*/
        public string ClientTabChannels = "a[href = '#tabs-7'] > span.ui-icon.icon-group.icon-channels.icons_Cln";

        //public string ClientAssistmeActive = ".container - app.container - module.admin.content.col.module.clients.details.tabContent.clChannels div[class = 'onoffswitch pull-right']";
        public string TextClientTabChanels = "Chanel tab";

        public string ClientSubmit = "div.clients > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";
    }
}