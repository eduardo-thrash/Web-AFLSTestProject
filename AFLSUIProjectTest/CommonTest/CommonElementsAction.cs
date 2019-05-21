using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;

namespace CommonTest.CommonTest
{
    public class CommonElementsAction
    {
        ///<summary> Global variables
        ///
        ///     IWebElement ElementWait = Inicializador de un elemento del DOM
        ///     Exception Ex = Objeto de tipo excepción para errores que se generen
        ///     string Error = Texto del mensaje de error
        ///     int second = variable de segundos a esperar para generar un error
        ///
        ///</summary>
        public static IWebElement ElementWait;

        public static Exception Ex;
        public static string Error;
        public static int second;
        private static int TimeWait = 30;

        ///<summary> AccessPage
        /// Método para acceder a una pagina especifica y maximizar la pantalla.
        ///     string Url: URL a la cual se accederá
        ///
        ///</summary>
        public static void AccessPage(string Url)
        {
            CommonHooks.driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            CommonHooks.driver.Navigate().GoToUrl(Url);
        }

        ///<summary> Click
        /// Método para identificar y hacer click sobre un elemento
        ///     string ElementType: Tipo de localizador (CssSelector, XPath, Id, Name, ClassName)
        ///     string Element: Elemento sobre el que se hará click
        ///
        /// </summary>
        public static void Click(string ElementType, string Element)
        {
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    switch (ElementType)
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

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
            Thread.Sleep(2000);
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    ElementWait.Click();
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        ///<summary> SendKeys_InputText
        /// Método para identificar y escribir texto en un campo de tipo input.
        ///     string ElementType: CssSelector, XPath, Id, Name, ClassName
        ///     string Input: Elemento de UIMap
        ///     string Value: Information or text for field
        ///
        /// </summary>
        public static void SendKeys_InputText(string ElementType, string Input, string Value)
        {
            for (second = 0; ; second++)
            {
                if (second >= 15) Assert.Fail(Error);
                try
                {
                    switch (ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    ElementWait.Click();
                    ElementWait.SendKeys(Value);
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        ///<summary> ClearAndSendKeys_InputText
        /// Método para limpiar campo e ingresar información, util al modificar un texto de un campo.
        ///    string ElementType: XPath, ClassName, Name, Id, CSSSelector
        ///     string Input: UIMap Input
        ///     string Value: text on the input
        ///
        /// </summary>
        public static void ClearAndSendKeys_InputText(string ElementType, string Input, string Value)
        {
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    switch (ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    ElementWait.Click();
                    ElementWait.Clear();
                    ElementWait.SendKeys(Value);
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        ///<summary> EnterAfterSendKeys_InputText
        /// Método para ingresar texto en campo y despues pulsar enter.
        ///     string ElementType: XPath, ClassName, Name, Id, CssSelector
        ///     string Input: UIMap Input
        ///     string Value: text on the input
        ///
        /// </summary>
        public static void EnterAfterSendKeys_InputText(string ElementType, string Input, string Value)
        {
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    switch (ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    ElementWait.Click();
                    ElementWait.SendKeys(Value);
                    ElementWait.SendKeys(Keys.Enter);
                    Thread.Sleep(2000);
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// Método para ingresar texto en campo de tipo busqueda por autocomplete y despues seleccionar una opción
        ///     string ElementType: XPath, ClassName, Name, Id, CssSelector
        ///     string List: UIMap List
        ///     string Option: Option for search
        ///     string tag: Tag of HTML (label,a,div,input,ul,etc)
        ///
        /// </summary>
        public static void Select_ComboboxAutocomplete(string ElementType, string List, string Option, string tag)
        {
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    switch (ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(List));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(List));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(List));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(List));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(List));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    ElementWait.Click();
                    ElementWait.SendKeys(Option);

                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
            Thread.Sleep(3000);
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    ElementWait = CommonHooks.driver.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    ElementWait.Click();
                    Thread.Sleep(2000);
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        public static void ClickAndSelect_Random_ComboboxAutocomplete(string ElementType, string Select, string Option)
        {
            int IndexStart = 0;
            int NumRandom = 0;
            IWebElement SelectElement = CommonHooks.driver.FindElement(By.XPath(Select));
            SelectElement.SendKeys(" ");
            Thread.Sleep(3000);

            IList<IWebElement> AllOptions = CommonHooks.driver.FindElements(By.XPath(Option));
            int NumOptions = AllOptions.Count;

            foreach (IWebElement Options in AllOptions)
            {
                Random rnd = new Random();
                NumRandom = rnd.Next(1, NumOptions);

                string TextNull = Options.Text;
                if (TextNull != "")
                {
                    IndexStart = 1;
                    break;
                }
            }

            Assert.IsTrue(NumRandom != 0);

            foreach (IWebElement Elements in AllOptions)
            {
                if (IndexStart == NumRandom)
                {
                    for (second = 0; ; second++)
                    {
                        if (second >= TimeWait) Assert.Fail(Error);
                        try
                        {
                            Assert.IsTrue(Elements.Enabled);
                            Assert.IsTrue(Elements.Displayed);
                            Assert.AreNotEqual(Elements.Size, 0);
                            Elements.Click();
                            Thread.Sleep(2000);
                            break;
                        }
                        catch (Exception Ex)
                        {
                            Error = Ex.Message;
                            Thread.Sleep(1000);
                        }
                    }
                }
                IndexStart++;
            }
        }

        #region Select DropDown List

        public static void ClickAndSelect_DropDownList(string ElementType, string List, string Option, string tag)
        {
            /*Método para dar click en un listado de opciones y despues seleccionar una opción*/

            //string ElementType: XPath, ClassName, Name, Id, CSSSelector
            //string List: UIMap List
            //string Option: Option for search
            //string tag: Tag of HTML (label,a,div,input,etc)
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    switch (ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(List));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(List));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(List));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(List));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(List));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    ElementWait.Click();

                    Thread.Sleep(2000);

                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
            Thread.Sleep(2000);
            for (int second = 0; ; second++)
            {
                if (second >= 5) Assert.Fail(Error);
                try
                {
                    ElementWait = CommonHooks.driver.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);

                    ElementWait.Click();
                    Thread.Sleep(2000);
                    break;
                }
                catch (Exception)
                { Thread.Sleep(1000); }
            }
        }

        #endregion Select DropDown List

        #region Clear

        ///<summary> Clear
        ///
        /// </summary>
        public static void Clear(string ElementType, string Input)
        {
            // string ElementType: CSS, XPath, Id, Name, ClassName
            // string Element: Elemento de UIMap
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    switch (ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CSS, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Ex.ToString());
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    ElementWait.Clear();
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        #endregion Clear

        #region Use Texts

        ///<summary> TextExtract
        ///
        /// </summary>
        public static string TextExtract(string ElementType, string Input)
        {
            /*Método para extraer texto entre una etiqueta. Ejemplo: <label> Texto </label>*/

            // string ElementType: CSS, XPath, Id, Name, ClassName
            // string Input: Elemento de UIMap

            string Text;

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    switch (ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CSS" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CSS, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    Text = ElementWait.Text;
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            return Text;
        }

        ///<summary> VallueExtract
        ///
        /// </summary>
        public static string VallueExtract(string ElementType, string Input)
        {
            string Value;

            /*Método para extraer texto entre una etiqueta. Ejemplo: <input value:"Texto">*/

            // string ElementType: CSS, XPath, Id, Name, ClassName
            // string Input: Elemento de UIMap
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    switch (ElementType)
                    {
                        case "Id":
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Input));
                            break;

                        case "Name":
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Input));
                            break;

                        case "ClassName":
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Input));
                            break;

                        case "CssSelector":
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Input));
                            break;

                        case "XPath":
                            ElementWait = CommonHooks.driver.FindElement(By.XPath(Input));
                            break;

                        default:
                            Assert.Fail("Incorrect Element");
                            break;
                    }
                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CSS" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName")
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CSS, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    Value = ElementWait.GetAttribute("value");
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            return Value;
        }

        #endregion Use Texts

        #region SwitchTo

        ///<summary>
        ///
        /// </summary>
        public static void EnterSwitchToiFrame()
        {
        }

        public static void CloseSwitchTiFrame()
        {
        }

        ///<summary>
        ///
        /// </summary>
        public static void ClickAndSwitchToNewTab()
        {
        }

        #endregion SwitchTo

        #region Select and/or Click random list

        ///<summary>
        ///
        /// </summary>

        #endregion Select and/or Click random list

        #region Select option of dropdown list

        public static void ClickAndSelect_Random_DropDownList(string ElementType, string Select, string Option, bool TakeIndexOne = true)
        {
            IWebElement SelectElement = CommonHooks.driver.FindElement(By.XPath(Select));
            SelectElement.Click();
            Thread.Sleep(1000);

            IList<IWebElement> AllOptions = CommonHooks.driver.FindElements(By.XPath(Option));
            int NumOptions = AllOptions.Count;
            int RandomNum;
            int start = 0;

            if (TakeIndexOne)
            {
                RandomNum = 1;
            }
            else
            {
                Random rnd = new Random();
                RandomNum = rnd.Next(2, NumOptions);
                start = 1;
            }

            foreach (IWebElement Elements in AllOptions)
            {
                if (start == RandomNum)
                {
                    for (second = 0; ; second++)
                    {
                        if (second >= TimeWait) Assert.Fail(Error);
                        try
                        {
                            Assert.IsTrue(Elements.Enabled);
                            Assert.IsTrue(Elements.Displayed);
                            Assert.AreNotEqual(Elements.Size, 0);
                            Elements.Click();
                            Thread.Sleep(2000);
                            break;
                        }
                        catch (Exception Ex)
                        {
                            Error = Ex.Message;
                            Thread.Sleep(1000);
                        }
                    }
                }
                start++;
            }
        }

        #endregion Select option of dropdown list

        #region Select random option of List

        public static string ClickOn_Random_List(string ElementType, string Option)
        {
            string TextOption = "";
            IList<IWebElement> AllOptions = CommonHooks.driver.FindElements(By.XPath(Option));
            Thread.Sleep(1000);
            int NumOptions = AllOptions.Count;

            Random rnd = new Random();
            int numeroConDosCotas = rnd.Next(1, NumOptions);
            int start = 1;

            foreach (IWebElement Elements in AllOptions)
            {
                if (start == numeroConDosCotas)
                {
                    TextOption = Elements.Text;
                    Elements.Click();
                }
                start++;
            }
            return TextOption;
        }

        #endregion Select random option of List

        ///<summary> Drag and Drop
        ///
        /// </summary>

        ///<summary> ExtractNumberOfText
        /// Método para extraer número de una cadena de texto
        ///     string Text: Texto del que se extraera el número.
        /// </summary>
        public static string ExtractNumberOfText(string Text)
        {
            Match number = Regex.Match(Text, "(\\d+)");
            string result = Convert.ToString(number);
            return result;
        }

        ///<summary> WaitElement
        /// Método para esperar que este disponible un elemento sin realizar ninguna acción sobre él.
        ///     string Element = Localizador Xpath del elemento.
        /// </summary>
        ///
        public static void WaitElement(string Element, string ElementType = null)
        {
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    if (ElementType == null)
                    {
                        ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                    }
                    else
                    {
                        switch (ElementType)
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

                            case "XPath":
                                ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                                break;

                            default:
                                Assert.Fail("Incorrect Element");
                                break;
                        }
                    }

                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName" && ElementType != null)
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        public static void WaitElementNoFound(string Element, string ElementType = null)
        {
            for (second = 0; ; second++)
            {
                if (second >= 5) break;
                try
                {
                    if (ElementType == null)
                    {
                        ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                    }
                    else
                    {
                        switch (ElementType)
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

                            case "XPath":
                                ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                                break;

                            default:
                                Assert.Fail("Incorrect Element");
                                break;
                        }
                    }

                    break;
                }
                catch (Exception Ex)
                {
                    if (ElementType != "CssSelector" && ElementType != "XPath" && ElementType != "Id" && ElementType != "Name" && ElementType != "ClassName" && ElementType != null)
                    {
                        Assert.Fail("Incorrect entry of parameter '" + ElementType + "'. (CssSelector, XPath, Id, Name, ClassName)");
                    }
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) break;
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    Assert.Fail("Unexpected element is visible");
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        public static void WaitUrl(string UrlExpected, string UrlActual)
        {
            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(UrlExpected.Contains(UrlActual));
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }

            for (second = 0; ; second++)
            {
                if (second >= TimeWait) Assert.Fail(Error);
                try
                {
                    Assert.IsTrue(ElementWait.Enabled);
                    Assert.IsTrue(ElementWait.Displayed);
                    Assert.AreNotEqual(ElementWait.Size, 0);
                    break;
                }
                catch (Exception Ex)
                {
                    Error = Ex.Message;
                    Thread.Sleep(1000);
                }
            }
        }

        public static void Select_OptionbyText(string DropDownList, string OptionDropDown)
        {
            new SelectElement(CommonHooks.driver.FindElement(By.XPath(DropDownList))).SelectByText(OptionDropDown);

            Thread.Sleep(1000);
        }
    }

    public class UtilAction
    {
        public static void Click(string Element, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            Thread.Sleep(1000);
            int CounterClick = 0;
            bool StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    IWebElement ElementWait = WebElement(Element, Locator);

                    ValidateDisplayed(Element);
                    ValidateEnabled(Element);
                    ValidateSize(Element, Locator);

                    ElementWait.Click();
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterClick++;
                    if (CounterClick == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Element);
                    }
                }
            }
            Thread.Sleep(1000);
        }

        public static string ValueExtract(string Input, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterExtract = 0;
            string Value = null;
            Thread.Sleep(1000);
            bool StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    IWebElement ElementWait = WebElement(Input, Locator);

                    ValidateDisplayed(Input);
                    ValidateEnabled(Input);
                    ValidateSize(Input, Locator);
                    Value = ElementWait.GetAttribute("value");
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterExtract++;
                    if (CounterExtract == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Input);
                    }
                }
            }
            Thread.Sleep(1000);
            return Value;
        }

        public static void SendKeys(string Element, string Value, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterSendKeys = 0;
            Thread.Sleep(1000);
            bool StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    IWebElement ElementWait = WebElement(Element, Locator);

                    ValidateDisplayed(Element);
                    ValidateEnabled(Element);
                    ValidateSize(Element, Locator);

                    ElementWait.Click();
                    Thread.Sleep(1000);
                    ElementWait.SendKeys(Value);
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterSendKeys++;
                    if (CounterSendKeys == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Element);
                    }
                }
            }
            Thread.Sleep(1000);
        }

        public static void EnterAfter_SendKeys(string Element, string Value, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterEnterAfter = 0;
            Thread.Sleep(1000);
            bool StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    IWebElement ElementWait = WebElement(Element, Locator);

                    ValidateDisplayed(Element);
                    ValidateEnabled(Element);
                    ValidateSize(Element, Locator);

                    ElementWait.Click();
                    ElementWait.SendKeys(Value);
                    Thread.Sleep(1000);
                    ElementWait.SendKeys(Keys.Enter);
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterEnterAfter++;
                    if (CounterEnterAfter == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Element);
                    }
                }
            }
            Thread.Sleep(1000);
        }

        public static void TabAfter_SendKeys(string Element, string Value, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterTabAfter = 0;
            Thread.Sleep(1000);
            bool StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    IWebElement ElementWait = WebElement(Element, Locator);

                    ValidateDisplayed(Element);
                    ValidateEnabled(Element);
                    ValidateSize(Element, Locator);

                    ElementWait.Click();
                    ElementWait.SendKeys(Value);
                    Thread.Sleep(1000);
                    ElementWait.SendKeys(Keys.Tab);
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterTabAfter++;
                    if (CounterTabAfter == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Element);
                    }
                }
            }
            Thread.Sleep(1000);
        }

        public static void ClearBefore_SendKeys(string Element, string Value, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterClearBefore = 0;
            Thread.Sleep(1000);
            bool StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    IWebElement ElementWait = WebElement(Element, Locator);

                    ValidateDisplayed(Element);
                    ValidateEnabled(Element);
                    ValidateSize(Element, Locator);

                    ElementWait.Click();
                    Thread.Sleep(1000);
                    ElementWait.Clear();
                    Thread.Sleep(1000);
                    ElementWait.SendKeys(Value);
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterClearBefore++;
                    if (CounterClearBefore == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Element);
                    }
                }
            }
            Thread.Sleep(1000);
        }

        public static void Clear(string Element, string Value, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterClear = 0;
            Thread.Sleep(1000);
            bool StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    IWebElement ElementWait = WebElement(Element, Locator);

                    ValidateDisplayed(Element);
                    ValidateEnabled(Element);
                    ValidateSize(Element, Locator);

                    ElementWait.Click();
                    Thread.Sleep(1000);
                    ElementWait.Clear();
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterClear++;
                    if (CounterClear == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Element);
                    }
                }
            }
            Thread.Sleep(1000);
        }

        public static void Select_ComboboxAutocomplete(string Field, string Option, string tag, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterComboboxAutocomplete = 0;
            Thread.Sleep(1000);
            bool StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    IWebElement ElementWait = WebElement(Field, Locator);

                    ValidateDisplayed(Field);
                    ValidateEnabled(Field);
                    ValidateSize(Field, Locator);

                    ElementWait.Click();
                    Thread.Sleep(1000);
                    ElementWait.Clear();
                    Thread.Sleep(1000);
                    ElementWait.SendKeys(Option);
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterComboboxAutocomplete++;
                    if (CounterComboboxAutocomplete == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Field);
                    }
                }
            }

            Thread.Sleep(1000);
            StaleElement = false;

            CounterComboboxAutocomplete = 0;
            TimeDefault = 3;
            MaxInteractions = 5;

            while (!StaleElement)
            {
                try
                {
                    IWebElement ElementWait = CommonHooks.driver.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));

                    ValidateDisplayed(Field);
                    ValidateEnabled(Field);
                    ValidateSize(Field, Locator);

                    ElementWait.Click();
                    Thread.Sleep(1000);
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterComboboxAutocomplete++;
                    if (CounterComboboxAutocomplete == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Field);
                    }
                }
            }
        }

        public void SelectOptionList(string Element, string Option, string tag, string Locator = "XPath", double TimeDefault = 5, int MaxInteractions = 5)
        {
            int CounterSelectOptionList = 0;
            Thread.Sleep(1000);
            bool StaleElement = false;
            while (!StaleElement)
            {
                try
                {
                    CommonHooks.driver.FindElement(By.XPath(Element)).Click();
                    Thread.Sleep(2000);
                    IWebElement ElementWait = CommonHooks.driver.FindElement(By.XPath("//" + tag + "[contains(text(),'" + Option + "')]"));

                    ValidateDisplayed("//" + tag + "[contains(text(),'" + Option + "')]");
                    ValidateEnabled("//" + tag + "[contains(text(),'" + Option + "')]");
                    ValidateSize("//" + tag + "[contains(text(),'" + Option + "')]", Locator);

                    ElementWait.Click();
                    Thread.Sleep(1000);
                    StaleElement = true;
                }
                catch (Exception e)
                {
                    CounterSelectOptionList++;
                    if (CounterSelectOptionList == MaxInteractions)
                    {
                        Assert.Fail(e.Message + " on element " + Option);
                    }
                    CommonHooks.driver.FindElement(By.XPath("//div[@class='mCSB_dragger_bar']")).Click();
                    CommonHooks.driver.FindElement(By.XPath(Element)).SendKeys(Keys.ArrowDown);
                }
            }
        }

        #region Validate's Method

        private static void ValidateDisplayed(string Element, string Locator = "XPath", bool IsDisplayed = false, double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterDisplayed = 0;
            IWebElement ElementWait = null;
            var wait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(TimeDefault));

            try
            {
                if (Locator == "XPath")
                {
                    wait.Until(d => d.FindElement(By.XPath(Element)).Displayed);
                    ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                }
                else
                {
                    switch (Locator)
                    {
                        case "Id":
                            wait.Until(d => d.FindElement(By.Id(Element)).Displayed);
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Element));
                            break;

                        case "Name":
                            wait.Until(d => d.FindElement(By.Name(Element)).Displayed);
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Element));
                            break;

                        case "ClassName":
                            wait.Until(d => d.FindElement(By.ClassName(Element)).Displayed);
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Element));
                            break;

                        case "CssSelector":
                            wait.Until(d => d.FindElement(By.CssSelector(Element)).Displayed);
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Element));
                            break;

                        default:
                            Assert.Fail("Incorrect entry of parameter '" + Locator + "'. (CssSelector, XPath, Id, Name, ClassName)");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                CounterDisplayed++;
                if (CounterDisplayed == MaxInteractions)
                {
                    Assert.Fail(e.Message + " on element " + Element);
                }
            }
        }

        private static void ValidateEnabled(string Element, string Locator = "XPath", bool IsEnabled = false, double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterEnabled = 0;
            IWebElement ElementWait = null;
            WebDriverWait wait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(TimeDefault));

            try
            {
                if (Locator == "XPath")
                {
                    wait.Until(d => d.FindElement(By.XPath(Element)).Enabled);
                }
                else
                {
                    switch (Locator)
                    {
                        case "Id":
                            wait.Until(d => d.FindElement(By.Id(Element)).Enabled);

                            break;

                        case "Name":
                            wait.Until(d => d.FindElement(By.Name(Element)).Enabled);

                            break;

                        case "ClassName":
                            wait.Until(d => d.FindElement(By.ClassName(Element)).Enabled);

                            break;

                        case "CssSelector":
                            wait.Until(d => d.FindElement(By.CssSelector(Element)).Enabled);

                            break;

                        default:
                            Assert.Fail("Incorrect entry of parameter '" + Locator + "'. (CssSelector, XPath, Id, Name, ClassName)");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                CounterEnabled++;
                if (CounterEnabled == MaxInteractions)
                {
                    Assert.Fail(e.Message + " on element " + Element);
                }
            }
        }

        private static void ValidateSize(string Element, string Locator, double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterSize = 0;
            IWebElement ElementWait = null;
            var SizeWait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(TimeDefault));

            try
            {
                switch (Locator)
                {
                    case "Id":
                        SizeWait.Until(d => d.FindElement(By.Id(Element)));
                        Assert.AreNotEqual(ElementWait.Size, 0);
                        break;

                    case "Name":
                        SizeWait.Until(d => d.FindElement(By.Name(Element)));
                        Assert.AreNotEqual(ElementWait.Size, 0);
                        break;

                    case "ClassName":
                        SizeWait.Until(d => d.FindElement(By.ClassName(Element)));
                        Assert.AreNotEqual(ElementWait.Size, 0);
                        break;

                    case "CssSelector":
                        SizeWait.Until(d => d.FindElement(By.CssSelector(Element)));
                        Assert.AreNotEqual(ElementWait.Size, 0);
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
            catch (Exception e)
            {
                CounterSize++;
                if (CounterSize == MaxInteractions)
                {
                    Assert.Fail(e.Message + " on element " + Element);
                }
            }
        }

        private static IWebElement WebElement(string Element, string Locator = "XPath", double TimeDefault = 3, int MaxInteractions = 5)
        {
            int CounterWebElement = 0;
            IWebElement ElementWait = null;

            WebDriverWait Ewait = new WebDriverWait(CommonHooks.driver, TimeSpan.FromSeconds(TimeDefault));

            try
            {
                if (Locator == "XPath")
                {
                    Ewait.Until(d => d.FindElement(By.XPath(Element)));
                    ElementWait = CommonHooks.driver.FindElement(By.XPath(Element));
                }
                else
                {
                    switch (Locator)
                    {
                        case "Id":
                            Ewait.Until(d => d.FindElement(By.Id(Element)));
                            ElementWait = CommonHooks.driver.FindElement(By.Id(Element));
                            break;

                        case "Name":
                            Ewait.Until(d => d.FindElement(By.Name(Element)));
                            ElementWait = CommonHooks.driver.FindElement(By.Name(Element));
                            break;

                        case "ClassName":
                            Ewait.Until(d => d.FindElement(By.ClassName(Element)));
                            ElementWait = CommonHooks.driver.FindElement(By.ClassName(Element));
                            break;

                        case "CssSelector":
                            Ewait.Until(d => d.FindElement(By.CssSelector(Element)));
                            ElementWait = CommonHooks.driver.FindElement(By.CssSelector(Element));
                            break;

                        default:
                            Assert.Fail("Incorrect entry of parameter '" + Locator + "'. (CssSelector, XPath, Id, Name, ClassName)");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                CounterWebElement++;
                if (CounterWebElement == MaxInteractions)
                {
                    Assert.Fail(e.Message + " on element " + Element);
                }
            }

            return ElementWait;
        }

        #endregion Validate's Method
    }
}