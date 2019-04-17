using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Safari;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using TechTalk.SpecFlow;

namespace CommonTest.CommonTest
{
    [Binding]
    public class CommonHooks
    {
        private static string Browser = ConfigurationManager.AppSettings["Browser"];

        //Chrome
        //Firefox
        //Explorer

        public static IWebDriver driver;

        public static ExtentTest feature;
        public static ExtentTest scenario;
        public static ExtentReports extent;

        public static string InitDate = DateTime.Now.ToString("dd/MM/yyyy");
        public static string InitTime = DateTime.Now.ToString("HH:mm");

        public static string ConvertDate = Regex.Replace(InitDate, "/", "").Replace(":", "-");
        public static string ConvertTime = Regex.Replace(InitTime, ":", "-");

        public static string Date = ConvertDate + "T" + ConvertTime;

        public static string BaseFolder = ConfigurationManager.AppSettings["PathProject"];

        public static string BaseReportFolder = BaseFolder + @"\Reports";
        public static string ReportFolder = BaseReportFolder + @"\ReportTest_" + Date;

        public static string BaseScreenshotFolder = BaseFolder + @"\Screenshots";
        public static string ScreenshotFolder = BaseScreenshotFolder + @"\Screenshots_" + Date;

        public static string ValidateGenerateReport = ConfigurationManager.AppSettings["GenerateReport"];

        public static string Screenshot()
        {
            string Image;

            if (!Directory.Exists(BaseScreenshotFolder))
                Directory.CreateDirectory(BaseScreenshotFolder);

            if (!Directory.Exists(ScreenshotFolder))
                Directory.CreateDirectory(ScreenshotFolder);

            Image = ScreenshotFolder + @"\Error " + FeatureContext.Current.FeatureInfo.Title + "-" + ScenarioContext.Current.ScenarioInfo.Title + ".jpg";
            driver.TakeScreenshot().SaveAsFile(Image, ScreenshotImageFormat.Jpeg);

            return Image;
        }

        public static string ScreenshotMassive(int num)
        {
            string Image;

            if (!Directory.Exists(BaseScreenshotFolder))
                Directory.CreateDirectory(BaseScreenshotFolder);

            if (!Directory.Exists(ScreenshotFolder))
                Directory.CreateDirectory(ScreenshotFolder);

            Image = ScreenshotFolder + @"\ErrorT" + num + " " + FeatureContext.Current.FeatureInfo.Title + "-" + ScenarioContext.Current.ScenarioInfo.Title + ".jpg";
            driver.TakeScreenshot().SaveAsFile(Image, ScreenshotImageFormat.Jpeg);

            return Image;
        }

        [BeforeTestRun]
        public static void BeforeExecution()

        {
            switch (ValidateGenerateReport)
            {
                case "true":
                    if (!Directory.Exists(BaseReportFolder))
                        Directory.CreateDirectory(BaseReportFolder);

                    if (!Directory.Exists(ReportFolder))
                        Directory.CreateDirectory(ReportFolder);

                    var htmlReporter = new ExtentV3HtmlReporter(ReportFolder + @"\ReportTest_" + Date + ".html");

                    htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

                    extent = new ExtentReports();

                    extent.AttachReporter(htmlReporter);
                    break;

                case "false":
                    break;

                default:
                    Assert.Fail("Incorrect condition" + ValidateGenerateReport + ". suggestion(true or false)");
                    break;
            }
        }

        [AfterTestRun]
        public static void AfterExecution()
        {
            switch (ValidateGenerateReport)
            {
                case "true":
                    extent.Flush();
                    break;

                case "false":
                    break;

                default:
                    Assert.Fail("Incorrect condition" + ValidateGenerateReport + ". suggestion(true or false)");
                    break;
            }
        }

        [BeforeFeature]
        public static void FeatureIn()
        {
            switch (ValidateGenerateReport)
            {
                case "true":
                    feature = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
                    break;

                case "false":
                    break;

                default:
                    Assert.Fail("Incorrect condition" + ValidateGenerateReport + ". suggestion(true or false)");
                    break;
            }
        }

        [AfterFeature]
        public static void FeatureOut()
        {
            switch (ValidateGenerateReport)
            {
                case "true":
                    FeatureContext.Current.FeatureInfo.Title.ToString();
                    break;

                case "false":
                    break;

                default:
                    Assert.Fail("Incorrect condition" + ValidateGenerateReport + ". suggestion(true or false)");
                    break;
            }
        }

        [BeforeScenario]
        public static IWebDriver Initalize()
        {
            switch (ValidateGenerateReport)
            {
                case "true":
                    scenario = feature.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
                    break;

                case "false":
                    break;

                default:
                    Assert.Fail("Incorrect condition" + ValidateGenerateReport + ". suggestion(true or false)");
                    break;
            }

            //TODO: implement logic that has to run before executing each scenario
            switch (Browser)
            {
                case "Chrome":
                    driver = new ChromeDriver(ConfigurationManager.AppSettings["BrowserDriverPath"]);
                    break;

                case "Firefox":
                    driver = new FirefoxDriver(ConfigurationManager.AppSettings["BrowserDriverPath"]);
                    break;

                case "Explorer":
                    InternetExplorerOptions options = new InternetExplorerOptions { IgnoreZoomLevel = true };
                    driver = new InternetExplorerDriver(ConfigurationManager.AppSettings["BrowserDriverPath"], options);
                    break;

                case "Edge":
                    driver = new EdgeDriver(ConfigurationManager.AppSettings["BrowserDriverPath"]);
                    break;

                case "Opera":
                    driver = new OperaDriver(ConfigurationManager.AppSettings["BrowserDriverPath"]);
                    break;

                case "Safari":
                    driver = new SafariDriver(ConfigurationManager.AppSettings["BrowserDriverPath"]);
                    break;

                default:
                    Assert.Fail("browser " + Browser + " option not found. Suggestions (Chrome, Firefox, Explorer, Edge, Opera, Safari.)");
                    break;
            }

            return driver;
        }

        [AfterScenario]
        public static void Teardown()
        {
            switch (ValidateGenerateReport)
            {
                case "true":
                    if (ScenarioContext.Current.TestError != null)
                    {
                        var error = ScenarioContext.Current.TestError;

                        Console.WriteLine("\n\nMENSAJES\n");
                        Console.WriteLine("Type Name: " + error.ToString());
                        Console.WriteLine("Type Name: " + error.GetType().Name);
                        Console.WriteLine("Type Module: " + error.GetType().Module.ToString());
                        Console.WriteLine("Type Namespace: " + error.GetType().Namespace);
                        Console.WriteLine("Type MemberType: " + error.GetType().MemberType.ToString());
                        Console.WriteLine("Type HelpLink: " + error.HelpLink);
                        Console.WriteLine("Type Message: " + error.Message);
                        Console.WriteLine("Type Source: " + error.Source);
                        Console.WriteLine("Type StackTrace: " + error.StackTrace);

                        Console.WriteLine("\n\nFIN MENSAJES\n");

                        scenario.Fail("details").AddScreenCaptureFromPath(Screenshot());
                    }
                    break;

                case "false":
                    break;

                default:
                    Assert.Fail("Incorrect condition" + ValidateGenerateReport + ". suggestion(true or false)");
                    break;
            }
            //TODO: implement logic that has to run after executing each scenario

            Thread.Sleep(2000);

            driver.Dispose();
        }

        [BeforeStep]
        public static void StepUp()
        {
            Thread.Sleep(500);
            Console.WriteLine("\n");
        }

        [AfterStep]
        public static void StepDown()
        {
            string ImageLink = "Error " + FeatureContext.Current.FeatureInfo.Title + "-" + ScenarioContext.Current.ScenarioInfo.Title + ".jpg";

            switch (ValidateGenerateReport)
            {
                case "true":
                    var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

                    if (ScenarioContext.Current.TestError == null)
                    {
                        if (stepType == "Given")
                            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                        else if (stepType == "When")
                            scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                        else if (stepType == "Then")
                            scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                        else if (stepType == "And")
                            scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                    }
                    else if (ScenarioContext.Current.TestError != null)
                    {
                        string MessageError = Regex.Replace(ScenarioContext.Current.TestError.Message, "<", "").Replace(">", "");

                        if (stepType == "Given")
                        {
                            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail("<i style=\"color: #ca6767;\">" + MessageError + ".</i>")
                                .Fail("Error evidence path: " + "<u><a href='" + Screenshot().ToString() + "'>" + ImageLink + "</a></u>");
                        }
                        else if (stepType == "When")
                        {
                            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail("<i style=\"color: #ca6767;\">" + MessageError + ".</i>")
                                .Fail("Error evidence path: " + "<u><a href='" + Screenshot().ToString() + "'>" + ImageLink + "</a></u>");
                        }
                        else if (stepType == "Then")
                        {
                            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail("<i style=\"color: #ca6767;\">" + MessageError + ".</i>")
                                .Fail("Error evidence path: " + "<u><a href='" + Screenshot().ToString() + "'>" + ImageLink + "</a></u>");
                        }
                        else if (stepType == "And")
                        {
                            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail("<i style=\"color: #ca6767;\">" + MessageError + ".</i>")
                                .Fail("Error evidence path: " + "<u><a href='" + Screenshot().ToString() + "'>" + ImageLink + "</a></u>");
                        }
                    }

                    if (ScenarioContext.Current.ScenarioExecutionStatus.ToString() == "StepDefinitionPending")
                    {
                        if (stepType == "Given")
                            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending.");
                        else if (stepType == "When")
                            scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending.");
                        else if (stepType == "Then")
                            scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending.");
                    }
                    break;

                case "false":
                    break;

                default:
                    Assert.Fail("Incorrect condition" + ValidateGenerateReport + ". suggestion(true or false)");
                    break;
            }
            Thread.Sleep(500);
        }

        public static void MassiveScenarioResult(int NumberTest, bool IsSuccess, string MessageError)
        {
            MessageError = Regex.Replace(MessageError, "<", "").Replace(">", "");

            switch (ValidateGenerateReport)
            {
                case "true":
                    if (IsSuccess)
                    {
                        scenario.CreateNode<When>("Test " + NumberTest + ": " + ScenarioStepContext.Current.StepInfo.Text).Pass("Sucess.");
                    }
                    else
                    {
                        scenario.CreateNode<When>("Test " + NumberTest + ": " + ScenarioStepContext.Current.StepInfo.Text).Fail("<i style=\"color: #ca6767;\"> " + "Failed | " + MessageError + ".</i>")
                        .Fail("<u><a href='" + ScreenshotMassive(NumberTest) + "'>Evidencia</a></u>")
                        .Fail("").AddScreenCaptureFromPath(ScreenshotMassive(NumberTest));
                    }
                    break;

                case "false":
                    break;

                default:
                    Assert.Fail("Incorrect condition" + ValidateGenerateReport + ". suggestion(true or false)");
                    break;
            }
        }
    }
}