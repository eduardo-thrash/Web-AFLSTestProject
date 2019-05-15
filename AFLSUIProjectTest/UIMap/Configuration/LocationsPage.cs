namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ElementsLocation
    {
        public string LocationModule = "zones";

        //public string LocationButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.zones #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string LocationSubmit = "div.zones > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        //Tab InfoContact
        public string LocationTabInfoContact = "a[href = '#tabs-3'] > span.ui-icon.icons_zones.icon_contact";

        public string InfoContactName = ".container-app .container-module .admin .content.col.module .zones .details .tabContent.zoneContact input[name='ContactName']";
        public string InfoContactPhone = ".container-app .container-module .admin .content.col.module .zones .details .tabContent.zoneContact input[name='ContactPhone']";
        public string InfoContactEmail = ".container-app .container-module .admin .content.col.module .zones .details .tabContent.zoneContact input[name='ContactMail']";

        public string TextLocationTabInfoContact = "Tab contact information";
        public string TextInfoContactName = "Contact Name";
        public string TextInfoContactPhone = "Contact Phone";
        public string TextInfoContactEmail = "Contact Email";
    }

    public class ElementsLocationHeadquater
    {
        public string LocationHeadquarterNew = "div.col.left.headquarter._newHeadquarte > div.col.title.left";

        //Tab Headquarter
        public string LocationTabHeadquater = "a[href = '#tabs-1'] > span.ui-icon.icons_zones.icon_headquater";

        public string LocationHeadquaterTypeHead = "#TypeHeadquarter > div.dd-select > a.dd-selected";
        public string LocationHeadquaterName = ".container-app .container-module .admin .content.col.module .zones .details .tabContent.zoneHeadquarter input[name='Name']";
        public string LocationHeadquaterDescription = ".container-app .container-module .admin .content.col.module .zones .details .tabContent.zoneHeadquarter textarea[name='Description']";
        public string LocationHeadquaterAddress = ".container-app .container-module .admin .content.col.module .zones .details .tabContent.zoneHeadquarter #adressHeadquarter";
        public string LocationAddressValidate = "//div[@class='zones']//div[@id='tabs-1']//div[@id='clientAddresCheck']";
        public string LocationHeadquaterAddresssDetail = ".container-app .container-module .admin .content.col.module .zones .details .tabContent.zoneHeadquarter input[name='AddlAddressInfo']";

        public string TextLocationTabHeadquater = "Tab Headquater";
        public string TextLocationHeadquaterTypeHead = "Type head";
        public string TextLocationHeadquaterName = "Name";
        public string TextLocationHeadquaterDescription = "Description";
        public string TextLocationHeadquaterAddress = "Address";
        public string TextLocationHeadquaterAddresssDetail = "Address detail";

        public string LocationHeadquaterState = "//div[@class='zones']//div[@id='tabs-1']//label[@class='onoffswitch-label']";
    }

    public class ElementsLocationTransport
    {
        public string LocationTransportNew = "div.col.left.transport._newTransport > div.col.title.left";

        //Tab Transport
        public string LocationTabTransport = "a[href = '#tabs-2'] > span.ui-icon.icons_zones.icon_transport";

        public string LocationTypeTransport = "#TypeTransport > div.dd-select > a.dd-selected";
        public string LocationNameTransport = ".container-app .container-module .admin .content.col.module .zones .details .tabContent.zoneTransport input[name='Name']";
        public string LocationDescriptionTransport = ".container-app .container-module .admin .content.col.module .zones .details .tabContent.zoneTransport textarea[name='Description']";

        public string TextLocationTabTransport = "Tab Transport";
        public string TextLocationTypeTransport = "Type transport";
        public string TextLocationNameTransport = "name";
        public string TextLocationDescriptionTransport = "Description";
    }
}