using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration
{
    public class ElementsASDK
    {
        public string ASDKModule = "ASDK";

        public string InputASDKConnection = "Url";//id
        public string ButtonASDKValidate = "btnTest";//Id
        public string SelectASDKProject = "//div[@id='ProjectId']/div/input[@class='dd-selected-value']";
        public string OptionASDKProject;
        public string RadioASDKClients = "//div[@id='tabs-1']/div/form/div[@class='row info-source']/div[@class='value valid']/label[@for='client']";
        public string RadioASDKCompanies = "//div[@id='tabs-1']/div/form/div[@class='row info-source']/div[@class='value valid']/label[@for='company']";
        public string InputASDKStartDate = "//div[@id='tabs-1']/div/form/div[3]/div[2]/div[2]/div/div[2]/div/input";
        public string CheckASDKSynchronization = "//div[@id='tabs-1']/div/form/div[3]/div[2]/div[4]/label/span";
        public string SelectASDKPeriodicity = "//div[@id='FrecuencyType']/div/span";
        public string OptionASDKPeriodicity = "//div[@id='FrecuencyType']/ul/li/a/label";
        public string ButtonASDKSave = "//div[@class='asdk']/div[@id='rightsidebar']/div/div[@class='row bottom comments']/div/input[@id='btnSave']";
        public string TabASDK = "//div[@class='asdk']/div[@id='rightsidebar']/div/div[@class='row top']/div/ul/li/a[@href='#tabs-1']";
       


        public string TextInputASDKConnection = "Connection";
        public string TextButtonASDKValidate = "Validate";
        public string TextSelectASDKProject = "Project";
        public string TextOptionASDKProject = "Option Project";
        public string TextRadioASDKClients = "Clients";
        public string TextRadioASDKCompanies = "Companies";
        public string TextInputASDKStartDate = "Start Date";
        public string TextCheckASDKSynchronization = "Synchronization";
        public string TextSelectASDKPeriodicity = "Periodicity";
        public string TextOptionASDKPeriodicity = "Option Periodicity";
        public string TextButtonASDKSave = "Save";
        public string TextTabASDK = "tab Service Desk";
    }
}
