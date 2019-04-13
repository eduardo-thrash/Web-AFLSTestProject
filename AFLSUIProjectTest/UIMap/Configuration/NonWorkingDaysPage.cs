using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Configuration
{
    public class ElementsNonWorkingDay
    {
        public string NonWorkingModule = "Non Working Days";

        public string InputNonWorkingDay = "//input[@id='Day']";

        public string ButtonNonWorkingaddDay = "//input[contains(@id,'addDay')]";

        public string ViewNonWorkingDate = "//form/div[2]/div/div/div/div/div/div/div/div";

        public string ButtonNonWorkingSave2 = "div.nonWorking > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnSave";
        public string ButtonNonWorkingSave = "div.nonWorking > #rightsidebar > div.content > div.row.bottom > div.buttons.row > #btnSave";

        public string ButtonNonWorkingCancel = "div.nonWorking > #rightsidebar > div.content > div.row.bottom.comments > div.buttons.row > #btnCancel";

    }
}
