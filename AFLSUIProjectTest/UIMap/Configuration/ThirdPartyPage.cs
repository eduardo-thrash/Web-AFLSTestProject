using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration
{
    public class ElementsThirdParty
    {
        public string ThirPartyModule = "Third Party";

        public string TabThirdPartyEventConfiguration = "//div[2]/div[2]/div/div/div/ul/li/a";
        public string TextTabThirdPartyEventConfiguration = "Tab events configuration";

        public string TabThirdPartySynchronizationConfiguration = "//div[2]/div[2]/div/div/div/ul/li[2]/a";
        public string TextTabThirdPartySynchronizationConfiguration = "Tab synchronization configuration";

        public string InputThirdPartyFile = "//div[@class='integration']/div[@id='rightsidebar']/div/div[1]/div/div[@id='tabs-1']/div/form/div[1]/div/div[2]/input[@id='file']";//XPath
        public string InputThirdPartyFilesasas = "//div[@class='integration']/div[@id='rightsidebar']/div/div[1]/div/div[@id='tabs-1']/div/form/div[1]/div/div[2]/input[@class='fileEvent']";
        
        public string TextInputThirdPartyFile = "File path";

        public string TextareaThirdPartuDescription = "//div[@class='integration']/div[@id='rightsidebar']/div/div[@class='row top']/div/div[@id='tabs-1']/div/form/div[@class='row description']/div[@class='value descriptiontext valid']/textarea";//XPath  
        public string TextTextareaThirdPartuDescription = "Description file of events of third parties";

        public string ButtonThridPArtySave = "(//input[@id='btnSave'])[2]";


    }
}
