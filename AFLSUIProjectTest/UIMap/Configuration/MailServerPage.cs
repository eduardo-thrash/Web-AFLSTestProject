using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration
{
    public class ElementsMailServer
    {
        public string ServerModule = "Mail Server";

        public string SwitchServerActive = "//div[@class='mail']/div[@id='rightsidebar']/div[@class='content']/div[@class='row top']/div/div[@id='tabs-1']/div/form/div/div[@class='two-column left']/div/div/div[@class='onoffswitch']/label[@for='myonoffswitch']";//div[@class='onoffswitch-inner']"; //XPath
        public string TextSwitchServerActive = "Server active";

        public string ListServerLanguage = "//select[@id='language']";//Id
        public string ListServerLanguageOptions = "//*[@id='language']/option";
        public string InputServerName = "ServerName";//Name
        public string InputServerPort = "Port"; //Name
        public string CheckServerSSL = "//div[@id='tabs-1']/div/form/div[2]/div[4]/div/div[2]/div/label/span[2]"; //XPath
        public string InputServerEmail = "UserAccount"; //Name
        public string InputServerPassword = "UserPassword";//Name
        public string InputServerNameSender = "SenderName"; //Name

        public string ButtonmailServerSave = "div.mail > #rightsidebar > div.content > div.row.bottom > div.buttons.row > #btnSave";

        public string ButtonMailServerCancel = "div.mail > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";


        public string TextListServerLanguage = "Language";
        public string TextInputServerName = "name";
        public string TextInputServerPort = "port";
        public string TextCheckServerSSL = "SSL";
        public string TextInputServerEmail = "email";
        public string TextInputServerPassword = "password";
        public string TextInputServerNameSender = "sender";

    }
}
