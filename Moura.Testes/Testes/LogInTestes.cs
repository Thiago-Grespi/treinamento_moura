using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages;
using System.IO;
using System.Reflection;

namespace Testes
{
    [TestClass]
    public class LogInTest
    {
        [TestMethod]
        public void LogInComSucesso()
        {
            string chromeDriverPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            IWebDriver driver = new ChromeDriver(chromeDriverPath);
            LogIn loginPage = new LogIn(driver);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(loginPage.url);

            loginPage.Logar("avalia", "111111");
        }
    }
}
