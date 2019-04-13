using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration
{
    public class ElementsLDAP
    {
        public string LDAPModule = "LDAP";

        public string TabLDAPSettings = "//div[@class='ldap']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-1']";
        public string TextTabLDAPSettings = "Tab Settings";

        public string SwitchLDAPActive = "//form[@id='settings']/div[@class='row top block']/div[@class='two-column left']/div[@class='two-column left']/div/div/div[@class='onoffswitch value']/label/div[@class='onoffswitch-inner']";
        public string TextSwitchLDAPActive = "Active LDAP";

        public string InputLDAPServer = "ProviderConfServer";//Name
        public string TextInputLDAPServer = "Server";

        public string InputLDAPUser = "OptionsLdapUser";//Name
        public string TextInputLDAPUser = "User";

        public string InputLDAPPassword = "OptionsSecurePassword";//Name
        public string TextInputLDAPPassword = "Password";

        public string CheckLDAPSecure = "//form[@id='settings']/div[@class='row basic block']/div[@class='two-column right']/div[@class='itemRow itemField ModAuth']/div/div/div/label[@for='Secure']/span[@class='icons_Ldap check']";
        public string TextCheckLDAPSecure = "Check Secure";

        public string InputFilterUser = "OptionsLdapFilterUser";//Name
        public string TextInputFilterUser = "Filter user";

        public string InputFilterGroup = "OptionsLdapFilterGroup";//Name
        public string TextInputFilterGroup = "Filter group";

        public string TabLDAPSynchronization = "//div[@class='ldap']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-2']";
        public string TextTabLDAPSynchronization = "Synchronization";

        public string TabLDAPFieldMatching = "//div[@class='ldap']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-3']";
        public string TextTabLDAPFieldMatching = "Field matching";

        public string Username = "1";
        public string TextUsername = "Username";

        public string Name = "2";
        public string TextName = "Name";

        public string Email = "10";
        public string TextEmail = "Email";

        public string Phone = "4";
        public string TextPhone = "Phone";

        public string Owner;
        public string TextOwner = "Owner";

        public string InmediateSupervisor = "22";
        public string TextInmediateSupervisor = "Inmediate supervisor";

        public string Position;
        public string TextPosition = "Position";

        public string Mobile = "8";
        public string TextMobile = "Mobile";

        public string ID = "17";
        public string TextID = "ID";

        public string GroupsFieldMapping = "21";
        public string TextGroupsFieldMapping = "Groups field mapping";
    }
}
