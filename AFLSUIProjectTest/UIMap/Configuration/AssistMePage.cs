using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration
{
    public class ElementsAssistMe
    {
        public string AssistMeModule = "AssistMe";
        public string AssistMeMenuPath = "//div[contains(@class, 'icon iconsAd channelsconfig')]";

        public string AssistMeSwitchState = "//div[@id='rightsidebar']/div/div[1]/div/div[@id='tabs-1']/div/form/div[1]/div/div/div[1]/div[1]/div[2]/label/div[2]";
        public string AssistMeInputURL = "AssistMeURL";//Id
        public string AssistMeInputAboutUsURL = "AboutUsURL";//Id
        public string AssistMeInputWelcomeMessage = "WelcomeMessage";//Id
        public string AssistMeInputNeeded = "Needed";//Id
        public string AssistMeInputAttendant = "Attendant";//Id
        public string AssistMeButtonSave = "//div[@class='assistme']/div[@id='rightsidebar']/div/div[2]/div/input[@id='btnSave']";//XPath

        public string TextAssistMeSwitchState = "State";
        public string TextAssistMeInputURL = "AssistMe URL";//Id
        public string TextAssistMeInputAboutUsURL = "About Us URL";//Id
        public string TextAssistMeInputWelcomeMessage = "Welcome Message";//Id
        public string TextAssistMeInputNeeded = "Name Needed";//Id
        public string TextAssistMeInputAttendant = "Name Attendant";//Id

        public string AssistMeInputServiceAssociate = "_channel_assistme_servicesAutocomplete";//Id
    }
}
