using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configuration
{
    class ElementsLicensing
    {
        public string LicenseModule = "Licensing";

        public string LicenseButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.licensing #content > div.center.header.row > div > div.btnSearch #commonNewItem";

        public string LicenseTab = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Lic";
        public string TextLicenseTab = "Tab Inicial";

        public string LicensingButtonFind = "#btnFind";

        public string LicensingFile = "#file";

        public string LicensetSubmit = "div.licensing > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string LicenseIconRemoved = "//div[@class='licensing']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']"; //Xpath
        public string TextLicenseIconRemoved = "Delete licensing icon";


        //Tab Specialits

        public string SpecialistTab = "a[href = '#tabs-3'] > span.ui-icon.icon-skills.icons_Lic";
        public string TextSpecialistTab = "Specialist Tab";

        public string LicenseSpecialistList = "//ul[@class='ui-autocomplete ui-front ui-menu ui-widget ui-widget-content ui-corner-all']/li/a[@class='ui-corner-all']";
        //public string LicenseSpecialistList = "//*[@id='ui-id-10']"

        public string SpecialistSearch = "//div[@id='tabs-3']/div/div/div/div[2]/form/div/input";
        public string TextSpecialistSearch = "Specialist Input";

        public string SpecialistIconRemoved = "//div.itemRow > div.Remove > #btnRemove";
        public string TextSpecialistIconRemoved = "Delete License Specialist ";

    }
}
