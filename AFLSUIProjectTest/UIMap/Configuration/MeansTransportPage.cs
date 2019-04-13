using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class MeansTransportPage
    {
        public string MeansTransportModule = "MeansTransports";
        public string MeansTransportButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.meansTransports #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string MeansTransportSubmit = "div.meansTransports > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string TransportFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.meansTransports #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextTransportFieldSearch = "Field Search";

        public string TransportButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.meansTransports #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextTransportButtonSearch = "Button Search";

        public string TransportView = "//div[@class='meansTransports']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //Xpath
        public string TextTransportView = "transport element view";

        public string TransportIconRemoved = "//div[@class='meansTransports']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']"; //Xpath
        public string TextTransportIconRemoved = "Delete transport icon";



        public string MeansTransportTabInfo = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Tr";
        public string MeansTransportName = ".container-app .container-module .admin .content.col.module .meansTransports .details .tabContent.svGeneral input[name='Name']";
        public string MeansTransportDescription = ".container-app .container-module .admin .content.col.module .meansTransports .details .tabContent.svGeneral textarea[name='Description']";
        public string MeansTransportInitialcost = ".container-app .container-module .admin .content.col.module .meansTransports .details .tabContent.svGeneral input[name='InitialCost']";
        public string MeansTransportCostByKilometer = ".container-app .container-module .admin .content.col.module .meansTransports .details .tabContent.svGeneral input[name='CostByKilometer']";
        public string MeansTransportsInfoTransport = "#Transport > div.dd-select > a.dd-selected";
        public string MeansTransportsInfoMeansTransport = "#TransportPublic > div.dd-select > a.dd-selected";

        public string TextMeansTransportTabInfo = "Information tab";
        public string TextMeansTransportName = "Name";
        public string TextMeansTransportDescription = "Description";
        public string TextMeansTransportInitialcost = "Initial Cost";
        public string TextMeansTransportCostByKilometer = "Cost By Kilometer";
        public string TextMeansTransportsInfoTransport = "transport type selector";
        public string TextMeansTransportsInfoMeansTransport = "public transport type selector";
    }
}
