using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configuration
{
    class ElementsPosition
    {
        public string PositionModule = "Positions";
        public string PositionButtonNew = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.positions #content > div.center.header.row > div > div.btnSearch #commonNewItem";
        public string PositionSubmit = "div.positions > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";

        public string PositionFieldSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.positions #content > div.center.header.row > div > div.searchBox #inputSearch";
        public string TextPositionFieldSearch = "Field Search";

        public string PositionButtonSearch = "body > div.frameworks > div > div.base.container-module.bottom.row > div > div.content.col.module > div.positions #content > div.center.header.row > div > div.searchBox #commonSearchItem";
        public string TextPositionButtonSearch = "Button Search";

        public string PositionView = "//div[@class='positions']/div/div[2]/div/div/div[@class='itemView selected']/div/div/h3"; //Xpath
        public string TextPositionView = "position element view";

        public string PositionIconRemoved = "//div[@class='positions']/div/div[2]/div/div/div[@class='itemView selected']/div[2]/div[@class='icon Remove']/input[@id='btnRemove']"; //Xpath
        public string TextPositionIconRemoved = "Delete position icon";

        public string PositionTabPositionInfo = "a[href = '#tabs-1'] > span.ui-icon.icon-general.icons_Pos";
        public string TextPositionTabPositionInfo = "Position Information";

        public string PositionName = ".container-app .container-module .admin .content.col.module .positions .details .tabContent.svGeneral input[name='Name']";
        public string TextPositionName = "name";

        public string PositionCost = ".container-app .container-module .admin .content.col.module .positions .details .tabContent.svGeneral input[name='Cost']";
        public string TextPositionCost = "cost";
    }
}
