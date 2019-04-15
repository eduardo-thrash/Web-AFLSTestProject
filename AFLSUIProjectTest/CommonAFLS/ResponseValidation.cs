using AFLSUIProjectTest.UIMap.AFLS;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace AFLSUIProjectTest.CommonAFLS
{
    public class ResponseValidation
    {
        public void ValidationSuccessCreate()
        {
            MessagesElements MessagesElements = new MessagesElements();
            MessagesCopies MessagesCopies = new MessagesCopies();

            IList<IWebElement> Messsages = CommonHooks.driver.FindElements(By.XPath(MessagesElements.ResponseElement));

            foreach (IWebElement Elements in Messsages)
            {
                string TextMessage = Elements.Text;
                Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessElementConfigurationCreateOrUpdate));
            }
        }
    }
}