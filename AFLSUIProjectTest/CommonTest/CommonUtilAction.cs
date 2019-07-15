using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace CommonTest
{
    public class CommonUtilAction
    {
        public void Click(string Element, string Locator = "XPath", int MaxInteractions = 5)
        {
            int CounterClick = 0;
            bool LocatedElement = false;
            IWebElement WebElement;

            while (!LocatedElement)
            {
                try
                {
                    ValidateDisplayed(Element, Locator, MaxInteractions);
                    ValidateEnabled(Element, Locator, MaxInteractions);
                    WebElement = ValidateSize(Element, Locator, MaxInteractions);

                    WebElement.Click();
                    LocatedElement = true;
                }
                catch (Exception e)
                {
                    CounterClick++;
                    if (CounterClick == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Element);
                    }
                    Thread.Sleep(1000);
                }
            }
        }

        public void SendKeys(string Element, string Locator = "XPath", int MaxInteractions = 5)
        {
            int CounterClick = 0;
            bool LocatedElement = false;
            IWebElement WebElement;

            while (!LocatedElement)
            {
                try
                {
                    ValidateDisplayed(Element, Locator, MaxInteractions);
                    ValidateEnabled(Element, Locator, MaxInteractions);
                    WebElement = ValidateSize(Element, Locator, MaxInteractions);

                    WebElement.Click();
                    LocatedElement = true;
                }
                catch (Exception e)
                {
                    CounterClick++;
                    if (CounterClick == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Element);
                    }
                    Thread.Sleep(1000);
                }
            }
        }

        public IWebElement ValidateDisplayed(string Element, string Locator = "XPath", int MaxInteractions = 10)
        {
            int CounterDisplayed = 0;
            bool LocatedElement = false;
            IWebElement ElementWait = null;

            while (!LocatedElement)
            {
                try
                {
                    if (Locator == "XPath")
                    {
                        ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                    }
                    else
                    {
                        switch (Locator)
                        {
                            case "Id":
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

                            default:
                                Assert.Fail("Incorrect entry of parameter '" + Locator + "'. (XPath, Id, Name, ClassName, CssSelector)");
                                break;
                        }
                    }

                    try
                    {
                        Assert.IsTrue(ElementWait.Displayed);
                    }
                    catch (Exception e)
                    {
                        CounterDisplayed++;
                        if (CounterDisplayed == MaxInteractions)
                        {
                            Assert.Fail("Element " + Locator + " not displayed.");
                        }
                    }
                }
                catch (Exception e)
                {
                    CounterDisplayed++;
                    if (CounterDisplayed == MaxInteractions)
                    {
                        Assert.Fail(e.Message);
                    }
                }
            }

            return ElementWait;
        }

        public IWebElement ValidateEnabled(string Element, string Locator = "XPath", int MaxInteractions = 10)
        {
            int CounterEnabled = 0;
            bool LocatedElement = false;
            IWebElement ElementWait = null;

            while (!LocatedElement)
            {
                try
                {
                    if (Locator == "XPath")
                    {
                        ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                    }
                    else
                    {
                        switch (Locator)
                        {
                            case "Id":
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

                            default:
                                Assert.Fail("Incorrect entry of parameter '" + Locator + "'. (XPath, Id, Name, ClassName, CssSelector)");
                                break;
                        }
                    }

                    try
                    {
                        Assert.IsTrue(ElementWait.Enabled);
                    }
                    catch (Exception e)
                    {
                        CounterEnabled++;
                        if (CounterEnabled == MaxInteractions)
                        {
                            Assert.Fail("Element " + Locator + " not displayed.");
                        }
                    }
                }
                catch (Exception e)
                {
                    CounterEnabled++;
                    if (CounterEnabled == MaxInteractions)
                    {
                        Assert.Fail(e.Message);
                    }
                }
            }

            return ElementWait;
        }

        public IWebElement ValidateSize(string Element, string Locator = "XPath", int MaxInteractions = 10)
        {
            int CounterSize = 0;
            bool LocatedElement = false;
            IWebElement ElementWait = null;

            while (!LocatedElement)
            {
                try
                {
                    if (Locator == "XPath")
                    {
                        ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                    }
                    else
                    {
                        switch (Locator)
                        {
                            case "Id":
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

                            default:
                                Assert.Fail("Incorrect entry of parameter '" + Locator + "'. (XPath, Id, Name, ClassName, CssSelector)");
                                break;
                        }
                    }

                    try
                    {
                        Assert.AreNotEqual(ElementWait.Size, 0);
                    }
                    catch (Exception e)
                    {
                        CounterSize++;
                        if (CounterSize == MaxInteractions)
                        {
                            Assert.Fail("Element " + Locator + " not displayed.");
                        }
                    }
                }
                catch (Exception e)
                {
                    CounterSize++;
                    if (CounterSize == MaxInteractions)
                    {
                        Assert.Fail(e.Message);
                    }
                }
            }

            return ElementWait;
        }
    }
}