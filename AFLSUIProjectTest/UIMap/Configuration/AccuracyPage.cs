using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSTestProjectUI.AFLSUIProjectTest.UIMap.Configuration.ElementsConfiguration
{
    public class ElementsAccuracy
    {
        public string AccuracyModule = "Accuracy";
        public string LowAccuracy = "//div[@class='accuracy']/div[@id='rightsidebar']/div[@class='content']/div[@class='row top']/div/div[@id='tabs-1']/div/div[@class='row bottom']/div/form/div[@class='col left']/div/div[@class='iconAccuracy']/div[@class='icon levelLow']";
        public string HighAccuracy = "//div[@class='accuracy']/div[@id='rightsidebar']/div[@class='content']/div[@class='row top']/div/div[@id='tabs-1']/div/div[@class='row bottom']/div/form/div[@class='col right']/div/div[@class='iconAccuracy']/div[@class='icon levelHight']";
        public string AverageAccuracy = "//div[@class='accuracy']/div[@id='rightsidebar']/div[@class='content']/div[@class='row top']/div/div[@id='tabs-1']/div/div[@class='row bottom']/div/form/div[@class='col center']/div/div[@class='iconAccuracy']/div[@class='icon levelMedium']";

        public string TextLowAccuracy = "Level Low";
        public string TextHighAccuracy = "Level hight";
        public string TextAverageAccuracy = "Level medium";

        public string AccuracySave = "//div[@class='accuracy']/div[@id='rightsidebar']/div/div[@class='row bottom']/div/input[@id='btnSave']";
    }
}
