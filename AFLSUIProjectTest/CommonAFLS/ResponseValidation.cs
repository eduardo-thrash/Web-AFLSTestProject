using AFLSUIProjectTest.UIMap.AFLS;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            int count = 15;
            for (int i = 1; i <= count; i++)
            {
                string TextMessage = "";

                try
                {
                    TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;
                    Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessElementConfigurationCreateOrUpdate));
                    break;
                }
                catch
                {
                    if (count == 15)
                    {
                        Assert.Fail(TextMessage);
                    }
                }
                Thread.Sleep(1000);
            }

            for (int i = 1; i <= count; i++)
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
            int countResponse = 0;
            bool Validate = false;
            while (!Validate)
            {
                try
                {
                    string Message = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseSuccessAFClient)).Text;
                    Assert.IsTrue(Message.Contains(MessagesCopies.SuccessResponseAF));
                    Validate = true;
                }
                catch
                {
                    try
                    {
                        string MessageError = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseErrorAFClient)).Text;
                        Assert.Fail(MessageError);
                        break;
                    }
                    catch
                    {
                        countResponse++;
                        if (countResponse == 10)
                        {
                            Assert.Fail("Timeout en respuesta de campos adicionales.");
                        }
                        Thread.Sleep(1000);
                    }
                }
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

        public string ValidationOrderCreate()
        {
            string TicketNumber = "";
            int count = 30;
            string TextMessage = "";
            for (int i = 1; i <= count; i++)
            {
                try
                {
                    TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;
                    Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessfulOrderCreation));
                    TicketNumber = CommonElementsAction.ExtractNumberOfText(TextMessage);
                    break;
                }
                catch
                {
                    if (i == count)
                    {
                        Assert.Fail(TextMessage);
                    }
                }
                Thread.Sleep(1000);
            }

            for (int i = 1; i <= 15; i++)
            {
                TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;
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
            return TicketNumber;
        }

        #region Validate's Method

        private static void ValidateDisplayed(string Element, bool IsDisplayed = false, double TimeDefault = 3, int MaxInteractions = 5)
        {
            var wait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(TimeDefault));
            wait.Until(d => d.FindElement(By.XPath(Element)).Displayed);
        }

        private static void ValidateEnabled(string Element, bool IsEnabled = false, double TimeDefault = 3, int MaxInteractions = 5)
        {
            var wait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(TimeDefault));
            wait.Until(d => d.FindElement(By.XPath(Element)).Enabled);
        }

        private static void ValidateSize(string Element, string Locator, double TimeDefault = 3, int MaxInteractions = 5)
        {
            IWebElement ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
            var SizeWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(TimeDefault));

            switch (Locator)
            {
                case "Id":
                    SizeWait.Until(d => d.FindElement(By.Id(Element)));
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    break;

                case "Name":
                    ElementWait = CommonHooks.driver.FindElement(By.Name(Element));
                    break;

                case "ClassName":
                    ElementWait = CommonHooks.driver.FindElement(By.ClassName(Element));
                    break;

                case "CssSelector":
                    ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Element));
                    break;

                case "XPath":
                    SizeWait.Until(d => d.FindElement(By.XPath(Element)));
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    break;

                default:
                    Assert.Fail("Incorrect Element");
                    break;
            }
        }

        private static IWebElement WebElement(string Element, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            IWebElement ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
            WebDriverWait Ewait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(TimeDefault));
            switch (Locator)
            {
                case "Id":
                    Ewait.Until(d => d.FindElement(By.Id(Element)));
                    ElementWait = CommonHooks.driver.FindElement(By.Id(Element));
                    break;

                case "Name":
                    ElementWait = CommonHooks.driver.FindElement(By.Name(Element));
                    break;

                case "ClassName":
                    ElementWait = CommonHooks.driver.FindElement(By.ClassName(Element));
                    break;

                case "CssSelector":
                    ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Element));
                    break;

                case "XPath":
                    Ewait.Until(d => d.FindElement(By.XPath(Element)));
                    ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                    break;

                default:
                    Assert.Fail("Incorrect Element");
                    break;
            }

            return ElementWait;
        }

        #endregion Validate's Method

        public void ValidateSuccessConfigurationCreate()
        {
            string TextMessage;
            int Counter = 0;
            int MaxInteractions = 10;
            bool StaleElement = false;

            while (!StaleElement)
            {
                try
                {
                    TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;
                    Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessElementConfigurationCreateOrUpdate));
                    StaleElement = true;
                }
                catch
                {
                    try
                    {
                        TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;
                        if (TextMessage != "")
                        {
                            Assert.IsFalse(TextMessage.Contains(MessagesCopies.SuccessElementConfigurationCreateOrUpdate));
                            Counter = MaxInteractions;
                            Assert.Fail(TextMessage);
                            StaleElement = true;
                        }
                        
                    }
                    catch (Exception e)
                    {
                        Counter++;
                        if (Counter >= MaxInteractions)
                        {
                            Assert.Fail(e.Message);
                        }
                    }
                    Thread.Sleep(1000);
                }
            }

            Counter = 0;
            StaleElement = false;

            while (!StaleElement)
            {
                try
                {
                    TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;

                    Assert.IsFalse(TextMessage.Contains(MessagesCopies.SuccessElementConfigurationCreateOrUpdate));
                    Assert.AreNotEqual("", TextMessage);
                    Assert.Fail(TextMessage);
                    StaleElement = true;
                }
                catch
                {
                    if (Counter == 8)
                    {
                        StaleElement = true;
                    }
                    Counter++;
                    Thread.Sleep(1000);
                }
            }
        }

        public string ValidateSuccessOrdernCreate()
        {
            string TicketNumber = "";
            int Counter = 0;
            int MaxInteractions = 30;
            string TextMessage;
            bool StaleElement = false;

            while (!StaleElement)
            {
                try
                {
                    TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;
                    Assert.IsTrue(TextMessage.Contains(MessagesCopies.SuccessfulOrderCreation));
                    TicketNumber = CommonElementsAction.ExtractNumberOfText(TextMessage);
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    Counter++;
                    if (Counter == MaxInteractions)
                    {
                        Assert.Fail(e.Message);
                    }
                    Thread.Sleep(1000);
                }
            }

            Counter = 0;
            StaleElement = false;

            while (!StaleElement)
            {
                try
                {
                    TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseElement)).Text;
                    Assert.IsFalse(TextMessage.Contains(MessagesCopies.SuccessfulOrderCreation));
                    Assert.AreNotEqual("", TextMessage);
                    Assert.Fail(TextMessage);
                    StaleElement = true;
                }
                catch
                {
                    if (Counter == 8)
                    {
                        StaleElement = true;
                    }
                    Counter++;
                    Thread.Sleep(1000);
                }
            }
            return TicketNumber;
        }
    }
}