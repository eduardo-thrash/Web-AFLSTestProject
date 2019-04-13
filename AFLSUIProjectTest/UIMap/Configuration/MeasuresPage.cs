using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ElementsMeasure
    {
        public string MeasureModule = "Measures";
        public string MeasureButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.measures #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string MeasureSubmit = "div.measures > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string MeasureFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.measures #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextMeasureFieldSearch = "Field Search";

        public string MeasureButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.measures #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextMeasureButtonSearch = "Button Search";


        public string MeasureView = "//div[@class='measures']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3";
        public string TextMeasureView = "measures view";

        public string MeasureIconRemoved = "//div[@class='measures']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']";
        public string TextMeasureIconRemoved = "Delete measures icon";

        //Tab Measures
        public string MeasureTabMeasures = "a[href = '#tabs-1'] > span.ui-icon.icon-measure.icons_Measure";
        public string MeasureName = ".container-app .container-module .admin .content.col.module .measures .details .tabContent.measure input[name='Name']";
        public string MeasureDescription = ".container-app .container-module .admin .content.col.module .measures .details .tabContent.measure textarea[name='Description']";

        public string TextMeasureTabMeasures = "Measure Tab";
        public string TextMeasureName = "Name";
        public string TextMeasureDescription = "Description";
    }
}
