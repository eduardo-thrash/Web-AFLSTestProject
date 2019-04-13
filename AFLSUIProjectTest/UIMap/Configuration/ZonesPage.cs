using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSTestProjectUI.AFLSUIProjectTest.UIMap.ElementsConfiguration
{
    class ZonesPage
    {
        //Elements SubMenu y option
        public string ZoneModule = "Zones";
        public string ZoneButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.coverageZones #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string ZoneSubmit = "div.coverageZones > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string ZoneFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.coverageZones #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextZoneFieldSearch = "Field Search";

        public string ZoneButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.coverageZones #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextZoneButtonSearch = "Button Search";

        public string ZoneView = "//div[@class='coverageZones']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextZoneView = "coverageZones view";

        public string ZoneIconRemoved = "//div[@class='coverageZones']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@class='btnRemove btns bg silver']";
        public string TextZoneIconRemoved = "Delete coverageZones icon";

        //Tab InfoZone
        public string ZoneTabZoneInfo = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_coverageZones";
        public string ZoneName = ".container-app .container-module .admin .content.col.module .coverageZones .details .tabContent.coverageZonesGeneral input[name='Name']";
        public string ZoneDescription = ".container-app .container-module .admin .content.col.module .coverageZones .details .tabContent.coverageZonesGeneral textarea[name='Description']";

        public string TextZoneTabZoneInfo = "Tab Zone info";
        public string TextZoneName = "Name";
        public string TextZoneDescription = "Description";

        //Tab Zone
        public string ZoneTabZone = "a[href = '#tabs-2'] > span.ui-icon.icon-zone.icons_coverageZones";
        public string TextZoneTabZone = "Tab Zones";

        //Tab Providers
        public string ZoneTabProviders = "a[href = '#tabs-3'] > span.ui-icon.icon-providers.icons_coverageZones";   
        public string ZoneProvider = "input.partSearch.ui-autocomplete-input";

        public string TextZoneTabProviders = "Tab providers";
        public string TextZoneProvider = "Provider";
    }
}
