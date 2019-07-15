using AFLSUIProjectTest.UIMap.AFLS;
using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;

namespace AFLSUIProjectTest.CommonAFLS
{
    public class AFLSCommonFunctions
    {
        private MessagesElements MessagesElements = new MessagesElements();

        private int second;

        public void MissingKeyFind()
        {
            string ErrorFindText = null;
            int secondFindText = 0;
            int NumIteractionFindText = 0;
            string FindText = "missing key";
            string UrlFindText;
            bool State = false;

            for (secondFindText = 0; ; secondFindText++)
            {
                if (secondFindText >= 10) Assert.Fail(ErrorFindText);
                try
                {
                    Assert.IsTrue(((IJavaScriptExecutor)CommonHooks.driver).ExecuteScript("return document.readyState").Equals("complete"));
                    break;
                }
                catch
                { }
            }

            Thread.Sleep(2000);
            UrlFindText = CommonHooks.driver.Url;

            IList<IWebElement> aText = CommonHooks.driver.FindElements(By.TagName("a"));
            Console.WriteLine("\n" + "Tag " + "a" + ":");

            foreach (IWebElement aElement in aText)
            {
                NumIteractionFindText++;
                string aTextWrite = aElement.Text;

                if (aTextWrite.Contains(FindText))
                {
                    Console.WriteLine("Text found:      " + aTextWrite + " in URL: " + "[ " + UrlFindText + " ]");
                    State = true;
                }
            }

            IList<IWebElement> spanText = CommonHooks.driver.FindElements(By.TagName("span"));
            Console.WriteLine("\n" + "Tag " + "span" + ":");

            foreach (IWebElement spanElement in spanText)
            {
                NumIteractionFindText++;
                string spanTextWrite = spanElement.Text;

                if (spanTextWrite.Contains(FindText))
                {
                    Console.WriteLine("Text found:      " + spanTextWrite + " in URL: " + "[ " + UrlFindText + " ]");
                    State = true;
                }
            }

            IList<IWebElement> pText = CommonHooks.driver.FindElements(By.TagName("p"));
            Console.WriteLine("\n" + "Tag " + "p" + ":");

            foreach (IWebElement pElement in pText)
            {
                NumIteractionFindText++;
                string pTextWrite = pElement.Text;

                if (pTextWrite.Contains(FindText))
                {
                    Console.WriteLine("Text found:      " + pTextWrite + " in URL: " + "[ " + UrlFindText + " ]");
                    State = true;
                }
            }

            IList<IWebElement> labelText = CommonHooks.driver.FindElements(By.TagName("label"));
            Console.WriteLine("\n" + "Tag " + "label" + ":");

            foreach (IWebElement labelElement in labelText)
            {
                NumIteractionFindText++;
                string labelTextWrite = labelElement.Text;

                if (labelTextWrite.Contains(FindText))
                {
                    Console.WriteLine("Text found:      " + labelTextWrite + " in URL: " + "[ " + UrlFindText + " ]");
                    State = true;
                }
            }

            IList<IWebElement> buttonText = CommonHooks.driver.FindElements(By.TagName("button"));
            Console.WriteLine("\n" + "Tag " + "button" + ":");

            foreach (IWebElement buttonElement in buttonText)
            {
                NumIteractionFindText++;
                string buttonTextWrite = buttonElement.Text;

                if (buttonTextWrite.Contains(FindText))
                {
                    Console.WriteLine("Text found:      " + buttonTextWrite + " in URL: " + "[ " + UrlFindText + " ]");
                    State = true;
                }
            }

            try
            {
                Assert.AreEqual(false, State);
            }
            catch (Exception e)
            {
                Assert.Fail(FindText + " Found in URL: " + "[ " + UrlFindText + " ]");
            }
        }

        public string RandomText(int longitud = 7)
        {
            Guid miGuid = Guid.NewGuid();
            string token = miGuid.ToString().Replace("-", string.Empty).Substring(0, longitud);
            return token;
        }

        public void CalendarDaySelection(bool disable = true)
        {
            string Error = null;
            Thread.Sleep(1000);
            bool CalendarFind = false;

            IList<IWebElement> CalendarControlList = CommonHooks.driver.FindElements(By.XPath("/html/body/div[@class='xdsoft_datetimepicker xdsoft_ xdsoft_noselect ']"));
            int index = 0;
            int cycle = 1;
            foreach (IWebElement ControlCalendar in CalendarControlList)
            {
                try
                {
                    string ElementOk = ControlCalendar.Text;
                    Assert.AreNotEqual(ElementOk, "");
                    CalendarFind = true;
                    index = cycle;
                    break;
                }
                catch (Exception e)
                {
                    Error = e.Message;
                }
                cycle++;
            }

            try
            {
                Assert.IsTrue(CalendarFind);
            }
            catch
            {
                Assert.Fail(Error);
            }
            for (int second = 0; ; second++)
            {
                try
                {
                    if (second >= 10) Assert.Fail(Error);

                    IWebElement Day = CommonHooks.driver.FindElement(By.XPath("(/html/body/div[@class='xdsoft_datetimepicker xdsoft_ xdsoft_noselect '])[" + index + "]/div[1]/div[2]/table/tbody/tr/td"));
                    Thread.Sleep(1);
                    Thread.Sleep(1);
                    Thread.Sleep(1);
                    Thread.Sleep(1);
                    Thread.Sleep(1);

                    IList<IWebElement> DaysList = CommonHooks.driver.FindElements(By.XPath("(/html/body/div[@class='xdsoft_datetimepicker xdsoft_ xdsoft_noselect '])[" + index + "]/div[1]/div[2]/table/tbody/tr/td"));

                    int EndIndex = DaysList.Count - 1;
                    if (disable)
                    {
                        Assert.IsTrue(DaysList[EndIndex].Enabled);
                        Assert.IsTrue(DaysList[EndIndex].Displayed);
                        Assert.AreNotEqual(DaysList[EndIndex], 0);
                        Thread.Sleep(500);
                        DaysList[EndIndex].Click();
                    }
                    else
                    {
                        Assert.IsTrue(DaysList[0].Enabled);
                        Assert.IsTrue(DaysList[0].Displayed);
                        Assert.AreNotEqual(DaysList[0], 0);
                        Thread.Sleep(500);
                        DaysList[0].Click();
                    }

                    break;
                }
                catch (Exception e)
                {
                    Error = e.Message;
                }
            }
        }

        public void DBInsert(string Query)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.AppSettings["DatabaseConnection"];

                conn.Open();

                using (SqlCommand command = new SqlCommand(Query, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DBEstablismentUpdate(string Query)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.AppSettings["DatabaseConnection"];

                conn.Open();

                using (SqlCommand command = new SqlCommand(Query, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DBUpdate(string Query)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = ConfigurationManager.AppSettings["DatabaseConnection"];

                conn.Open();

                using (SqlCommand command = new SqlCommand(Query, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ErrorFindOnPage()
        {
            int count = 10;
            for (int i = 1; i <= count; i++)
            {
                try
                {
                    string TextMessage = CommonHooks.driver.FindElement(By.XPath(MessagesElements.ResponseError)).Text;
                    Assert.Fail(TextMessage);
                    break;
                }
                catch
                {
                    Thread.Sleep(1000);
                }
            }
        }
    }
}