using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace CommonTest
{
    public class ElementsUtilAction
    {
        private static int Second = 3;
        private static int Interactions = 20;
        private static bool StaleElement = false;
        private static int Timeout = 0;

        private static void Displayed(By Element)
        {
            StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    WebDriverWait DisplayedWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(Second));
                    DisplayedWait.Until(d => d.FindElement(Element));

                    IWebElement ElementWait = CommonHooks.driver.FindElement(Element);
                    Assert.IsTrue(ElementWait.Displayed);
                    StaleElement = true;
                }
                catch
                {
                    Timeout++;
                    if (Timeout == Interactions)
                        Assert.Fail("Element not displayed");
                }
            }
        }

        private static void Enabled(By Element)
        {
            StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    WebDriverWait EnabledWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(Second));
                    EnabledWait.Until(d => d.FindElement(Element));
                    IWebElement ElementWait = CommonHooks.driver.FindElement(Element);
                    Assert.IsTrue(ElementWait.Enabled);
                    StaleElement = true;
                }
                catch
                {
                    Timeout++;
                    if (Timeout == Interactions)
                        Assert.Fail("Element not enabled");
                }
            }
        }

        public static void Click(By ElementClick)
        {
            WebDriverWait ClickWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(Second));

            StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    ClickWait.Until(d => d.FindElement(ElementClick));
                    Displayed(ElementClick);
                    Enabled(ElementClick);
                    IWebElement ElementWeb = CommonHooks.driver.FindElement(ElementClick);

                    Actions ac = new Actions(CommonHooks.driver);
                    ac.MoveToElement(ElementWeb);
                    ac.Click().Build().Perform();

                    StaleElement = true;
                }
                catch (Exception e)
                {
                    Timeout++;
                    if (Timeout == Interactions)
                    {
                        int Total = Second * Interactions;
                        Assert.Fail(e.Message + " per " + Interactions + " tries. Total: " + Total.ToString() + " seconds.\n\n" + e.InnerException + ".");
                    }
                }
            }
        }

        public static void SendKeys(By ElementSendKeys, string Text)
        {
            StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    WebDriverWait ElementWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(Second));
                    ElementWait.Until(d => d.FindElement(ElementSendKeys));
                    Displayed(ElementSendKeys);
                    Enabled(ElementSendKeys);
                    IWebElement ElementWeb = CommonHooks.driver.FindElement(ElementSendKeys);

                    Actions ac = new Actions(CommonHooks.driver);
                    ac.MoveToElement(ElementWeb);
                    ElementWeb.Clear();
                    ac.Click().SendKeys(Text).Build().Perform();

                    StaleElement = true;
                }
                catch (Exception e)
                {
                    Timeout++;
                    if (Timeout == Interactions)
                    {
                        int Total = Second * Interactions;
                        Assert.Fail(e.Message + " per " + Interactions + " tries. Total: " + Total.ToString() + " seconds.\n\n" + e.InnerException + ".");
                    }
                }
            }
        }

        public static void EnterAfterSendKeys(By ElementEnter, string Text)
        {
            StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    WebDriverWait ElementWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(Second));
                    ElementWait.Until(d => d.FindElement(ElementEnter));
                    Displayed(ElementEnter);
                    Enabled(ElementEnter);
                    IWebElement ElementWeb = CommonHooks.driver.FindElement(ElementEnter);

                    Actions ac = new Actions(CommonHooks.driver);
                    ac.MoveToElement(ElementWeb);
                    ElementWeb.Clear();
                    ac.Click().SendKeys(Text);
                    ac.SendKeys(Keys.Enter);
                    ac.Build().Perform();

                    StaleElement = true;
                }
                catch (Exception e)
                {
                    Timeout++;
                    if (Timeout == Interactions)
                    {
                        int Total = Second * Interactions;
                        Assert.Fail(e.Message + " per " + Interactions + " tries. Total: " + Total.ToString() + " seconds.\n\n" + e.InnerException + ".");
                    }
                }
            }
        }

        public static void SelectDropDownList(By DropDown, string Option, string tag)
        {
            StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    WebDriverWait ElementWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(Second));
                    ElementWait.Until(d => d.FindElement(DropDown));
                    Displayed(DropDown);
                    Enabled(DropDown);
                    IWebElement ElementWeb = CommonHooks.driver.FindElement(DropDown);

                    Actions ac = new Actions(CommonHooks.driver);
                    ac.MoveToElement(ElementWeb);
                    ac.Click().Build().Perform();
                }
                catch (Exception e)
                {
                    Timeout++;
                    if (Timeout == Interactions)
                    {
                        int Total = Second * Interactions;
                        Assert.Fail(e.Message + " per " + Interactions + " tries. Total: " + Total.ToString() + " seconds.\n\n" + e.InnerException + ".");
                    }
                }
            }

            StaleElement = false;
            Timeout = 0;

            while (!StaleElement)
            {
                try
                {
                    WebDriverWait ElementWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(Second));
                    ElementWait.Until(d => d.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]")));
                    Displayed(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));
                    Enabled(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));

                    IWebElement ElementOption = CommonHooks.driver.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));

                    Actions ac = new Actions(CommonHooks.driver);
                    ac.MoveToElement(ElementOption);
                    ac.Click().Build().Perform();
                }
                catch (Exception e)
                {
                    Timeout++;
                    if (Timeout == Interactions)
                    {
                        int Total = Second * Interactions;
                        Assert.Fail(e.Message + " per " + Interactions + " tries. Total: " + Total.ToString() + " seconds.\n\n" + e.InnerException + ".");
                    }
                }
            }
        }

        public static void Select_ComboboxAutocomplete(By ComboBox, string Option, string tag)
        {
            StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    WebDriverWait ElementWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(Second));
                    ElementWait.Until(d => d.FindElement(ComboBox));
                    Displayed(ComboBox);
                    Enabled(ComboBox);
                    IWebElement ElementWeb = CommonHooks.driver.FindElement(ComboBox);

                    Actions ac = new Actions(CommonHooks.driver);
                    ac.MoveToElement(ElementWeb);
                    ac.Click().SendKeys(Option).Build().Perform();
                }
                catch (Exception e)
                {
                    Timeout++;
                    if (Timeout == Interactions)
                    {
                        int Total = Second * Interactions;
                        Assert.Fail(e.Message + " per " + Interactions + " tries. Total: " + Total.ToString() + " seconds.\n\n" + e.InnerException + ".");
                    }
                }
            }

            StaleElement = false;
            Timeout = 0;

            while (!StaleElement)
            {
                try
                {
                    WebDriverWait ElementWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(Second));
                    ElementWait.Until(d => d.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]")));
                    Displayed(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));
                    Enabled(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));

                    IWebElement ElementOption = CommonHooks.driver.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));

                    Actions ac = new Actions(CommonHooks.driver);
                    ac.MoveToElement(ElementOption);
                    ac.Click().Build().Perform();
                }
                catch (Exception e)
                {
                    Timeout++;
                    if (Timeout == Interactions)
                    {
                        int Total = Second * Interactions;
                        Assert.Fail(e.Message + " per " + Interactions + " tries. Total: " + Total.ToString() + " seconds.\n\n" + e.InnerException + ".");
                    }
                }
            }
        }
    }
}