using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFLSUIProjectTest.UIMap.Orders
{
    public class WorkordersPage
    {
        #region Common

        private static string WOContent = "//div[@class='workOrder contentWO']";

        private static string FormNew = "//div[@class='col panel left header new']";

        #endregion Common

        public string ClientName = WOContent + FormNew + "//input[@name='clientName']";

        public string ContactName = WOContent + FormNew + "//input[@name='ContactName']";
        public string ContactPhone = WOContent + FormNew + "//input[@name='ContactPhone']";
        public string ContactEmail = WOContent + FormNew + "//input[@name='ContactEmail']";
        public string Address = WOContent + FormNew + "//input[@id='address']";
        public string AddressEndPoint = WOContent + FormNew + "//input[@id='addressEndPoint']";
        public string AddlAddressInfo = WOContent + FormNew + "//input[@name='AddlAddressInfo']";
        public string EndAddlAddressInfo = WOContent + FormNew + "//input[@name='EndAddlAddressInfo']";
        public string ServiceName = WOContent + FormNew + "//input[@name='ServiceName']";

        public string OptionOrderNormal = WOContent + FormNew + "//div[@data-action='normal']";
        public string OptionOrderEmergency = WOContent + FormNew + "//div[@data-action='emergency']";

        public string OptionOrderPriority = WOContent + FormNew + "//div[@data-action='priority']";

        public string Subject = WOContent + FormNew + "//div[@name='Subject']";

        public string Description = WOContent + FormNew + "//div[@class='contentEditable']";

        public string Save = WOContent + FormNew + "//div[@data-action='normal']";

        public string Exit = WOContent + FormNew + "//div[@data-action='normal']";
    }
}