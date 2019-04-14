using CommonTest.CommonTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace AFLSUIProjectTest.CommonAFLS
{
    public class AFLSCommonFunctions
    {
        private int second;

        public void MissingKeyFind()
        {
            string ErrorFindText = null;
            int secondFindText = 0;
            int NumIteractionFindText = 0;
            string FindText = "Form";
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

        //public static void GetTextPage(IWebDriver driver,string FileSectionModule,string LocalDateTimeExecution)
        //{
        //    WebDriverWait wait = new WebDriverWait(CommonHooks.driver,TimeSpan.FromSeconds(30));
        //    try
        //    {
        //        wait.Until((x) =>
        //        {
        //            return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
        //        });
        //    }
        //    catch(Exception UnhandledAlertException) { }

        //    WebDriverWait WaitElementsPage = new WebDriverWait(CommonHooks.driver,TimeSpan.FromSeconds(4));

        //    //Validar si existe directorio de carpeta
        //    string DateTimeFolder = Regex.Replace(LocalDateTimeExecution,"/","");
        //    DateTimeFolder = Regex.Replace(DateTimeFolder,":","-");

        //    var DirectoryFolderPath = @"D:\Automation\AutomationSpecflow\ProjectTestUIAutomation\ProjectTestEasyManagment\PageCopies\PagesCopies" + DateTimeFolder;

        //    if(!Directory.Exists(DirectoryFolderPath))
        //    {
        //        Directory.CreateDirectory(DirectoryFolderPath);
        //    }

        //    //Validar si existe directorio de carpeta + archivo
        //    string Url = "";
        //    try
        //    {
        //        Url = driver.Url.ToString();
        //    }
        //    catch(Exception UnhandledAlertException) { }

        //    if(Url != "data:," && Url != "")
        //    {
        //        Url = Regex.Replace(Url,"/","_");
        //        Url = Regex.Replace(Url,":"," ");

        //        var DirectoryFilePath = DirectoryFolderPath + @"\" + FileSectionModule + " - " + Url + ".doc";

        //        if(!File.Exists(DirectoryFilePath))
        //        {
        //            File.AppendAllText(Path.Combine(DirectoryFilePath),"BEGIN " + FileSectionModule + "\r\n\r\n");

        //            File.AppendAllText(Path.Combine(DirectoryFilePath),"\n" + "Title: " + driver.Title.ToString() + "\n");
        //            File.AppendAllText(Path.Combine(DirectoryFilePath),"\n" + "Url: " + driver.Url.ToString() + "\n");
        //            File.AppendAllText(Path.Combine(DirectoryFilePath),"\n" + "Pagesource: " + driver.PageSource.ToString() + "\n");

        //            try
        //            {
        //                WaitElementsPage.Until(d => CommonHooks.driver.FindElement(By.TagName("body")));

        //                var Text = driver.FindElement(By.TagName("body")).Text;

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- Text Module -------------------------" + "\r\n\r\n");

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),Text);

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- Text Module -------------------------" + "\r\n\r\n");
        //            }
        //            catch
        //            {
        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "> > Text Module no found" + "\r\n\r\n");
        //            }

        //            try
        //            {
        //                WaitElementsPage.Until(d => CommonHooks.driver.FindElement(By.TagName("input")));

        //                IList<IWebElement> Tags = driver.FindElements(By.TagName("input"));

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- input value -------------------------" + "\r\n\r\n");

        //                foreach(IWebElement Element in Tags)
        //                {
        //                    string value = Element.GetAttribute("value");

        //                    File.AppendAllText(Path.Combine(DirectoryFilePath),value + "\r\n");
        //                }

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- input value -------------------------" + "\r\n\r\n");
        //            }
        //            catch
        //            {
        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "> > input value no found" + "\r\n\r\n");
        //            }

        //            try
        //            {
        //                WaitElementsPage.Until(d => CommonHooks.driver.FindElement(By.TagName("div")));

        //                IList<IWebElement> Tags = driver.FindElements(By.TagName("div"));

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- div value -------------------------" + "\r\n\r\n");

        //                foreach(IWebElement Element in Tags)
        //                {
        //                    string value = Element.GetAttribute("value");

        //                    File.AppendAllText(Path.Combine(DirectoryFilePath),value + "\r\n");
        //                }

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- div value -------------------------" + "\r\n\r\n");
        //            }
        //            catch
        //            {
        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "> > div value no found" + "\r\n\r\n");
        //            }

        //            try
        //            {
        //                WaitElementsPage.Until(d => CommonHooks.driver.FindElement(By.TagName("label")));

        //                IList<IWebElement> Tags = driver.FindElements(By.TagName("label"));

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- label value -------------------------" + "\r\n\r\n");

        //                foreach(IWebElement Element in Tags)
        //                {
        //                    string value = Element.GetAttribute("value");

        //                    File.AppendAllText(Path.Combine(DirectoryFilePath),value + "\r\n");
        //                }

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- label value -------------------------" + "\r\n\r\n");
        //            }
        //            catch
        //            {
        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "> > label value no found" + "\r\n\r\n");
        //            }

        //            try
        //            {
        //                WaitElementsPage.Until(d => CommonHooks.driver.FindElement(By.TagName("label")));

        //                IList<IWebElement> Tags = driver.FindElements(By.TagName("label"));

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- label after -------------------------" + "\r\n\r\n");

        //                foreach(IWebElement Element in Tags)
        //                {
        //                    string value = Element.GetAttribute("after");

        //                    File.AppendAllText(Path.Combine(DirectoryFilePath),value + "\r\n");
        //                }

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- label after -------------------------" + "\r\n\r\n");
        //            }
        //            catch
        //            {
        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "> > label after no found" + "\r\n\r\n");
        //            }

        //            try
        //            {
        //                WaitElementsPage.Until(d => CommonHooks.driver.FindElement(By.TagName("label")));

        //                IList<IWebElement> Tags = driver.FindElements(By.TagName("label"));

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- label before -------------------------" + "\r\n\r\n");

        //                foreach(IWebElement Element in Tags)
        //                {
        //                    string value = Element.GetAttribute("before");

        //                    File.AppendAllText(Path.Combine(DirectoryFilePath),value + "\r\n");
        //                }

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- label before -------------------------" + "\r\n\r\n");
        //            }
        //            catch
        //            {
        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "> > label before no found" + "\r\n\r\n");
        //            }

        //            try
        //            {
        //                WaitElementsPage.Until(d => CommonHooks.driver.FindElement(By.TagName("button")));

        //                IList<IWebElement> Tags = driver.FindElements(By.TagName("button"));

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- button value -------------------------" + "\r\n\r\n");

        //                foreach(IWebElement Element in Tags)
        //                {
        //                    string value = Element.GetAttribute("value");

        //                    File.AppendAllText(Path.Combine(DirectoryFilePath),value + "\r\n");
        //                }

        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "------------------------- button value -------------------------" + "\r\n\r\n");
        //            }
        //            catch
        //            {
        //                File.AppendAllText(Path.Combine(DirectoryFilePath),"\r\n\r\n" + "> > button value no found" + "\r\n\r\n");
        //            }

        //            File.AppendAllText(Path.Combine(DirectoryFilePath),"END " + FileSectionModule + "\r\n\r\n");
        //        }
        //    }
        //}
    }
}