using AFLSUIProjectTest.UIMap.AFLS;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AFLSUIProjectTest.CommonAFLS
{
    public class ResponseValidation
    {
        private MessagesElements MessagesElements = new MessagesElements();
        private MessagesCopies MessagesCopies = new MessagesCopies();

        public void ValidationSuccessCreate()
        {
            for (int i = 1; i <= 8; i++)
            {
                string TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;
                try
                {
                    Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessElementConfigurationCreateOrUpdate));
                    break;
                }
                catch
                {
                    Assert.Fail(TextMessage);
                }
                Thread.Sleep(1000);
            }

            for (int i = 1; i <= 8; i++)
            {
                string TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;
                try
                {
                    Assert.IsFalse(TextMessage.Contains(MessagesCopies.SuccessElementConfigurationCreateOrUpdate));
                    Assert.Fail(TextMessage);
                    break;
                }
                catch
                {
                    Thread.Sleep(1000);
                }
            }
        }

        public void ValidationSuccessAFCreate(string Element)
        {
            IList<IWebElement> Messsages = CommonHooks.driver.FindElements(By.XPath(Element));

            foreach (IWebElement Elements in Messsages)
            {
                string TextMessage = Elements.Text;
                Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessResponseAF));
            }
        }

        public void ValidationSuccessSurvey(string Element)
        {
            IList<IWebElement> Messsages = CommonHooks.driver.FindElements(By.XPath(Element));

            foreach (IWebElement Elements in Messsages)
            {
                string TextMessage = Elements.Text;
                Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessSurveyConfig));
            }
        }

        public void ValidationSuccessDelete()
        {
            IList<IWebElement> Messsages = CommonHooks.driver.FindElements(By.XPath(MessagesElements.ResponseElement));

            foreach (IWebElement Elements in Messsages)
            {
                string TextMessage = Elements.Text;
                try
                {
                    Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessElementConfigurationDelete));
                }
                catch
                {
                    Assert.Fail(TextMessage);
                }
            }
        }

        public void ValidateErrorAplication()
        {
            string Error = null;
            for (int second = 0; ; second++)
            {
                if (second >= 10) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(((IJavaScriptExecutor)CommonHooks.driver).ExecuteScript("return document.readyState").Equals("complete"));
                    break;
                }
                catch (Exception e)
                { Error = e.Message; }
            }

            for (int second = 0; ; second++)
            {
                if (second >= 5) break;
                {
                    try
                    {
                        Assert.IsTrue(CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseError)).Enabled);
                        Assert.IsTrue(CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseError)).Displayed);
                        Assert.AreNotEqual(CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseError)).Size, 0);
                        Error = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseError)).Text;
                        Assert.Fail(Error);
                    }
                    catch { }
                }
            }
        }
    }
}