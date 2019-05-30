using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;

namespace CommonTest.CommonTest
{
    [TestClass]
    public class SystemTask
    {
        public void KillChromeDriver()
        {
            int a = 0;
            try
            {
                foreach (Process proceso in Process.GetProcessesByName("chromedriver"))
                {
                    if (a < 60)
                    {
                        proceso.Kill();
                        a++;
                        Thread.Sleep(1000);
                    }
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }

            Console.WriteLine(a + " procesos eliminados.");
        }
    }
}