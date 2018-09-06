using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Selenium.Constants;

namespace Selenium.Login.Chrome
{
    [TestClass]
    public class CanLogin
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\ccl002\source\repos\Clockwork-AWH\awhcode-clockwork-repo-a3b620f80baa\Selenium\bin\Debug\netcoreapp2.1");

        [TestMethod]
        public async Task User_CanSuccessfully_Login()
        {
            try
            {
                //Test - Login with valid credentials
                driver.Navigate().GoToUrl(TestAccounts.loginUrl);
                Assert.AreEqual(TestAccounts.loginUrl, driver.Url);

                var userName = driver.FindElement(By.Id("Input_Email"));
                var password = driver.FindElement(By.Id("Input_Password"));
                var loginButton = driver.FindElement(By.XPath("//button[text()='Log in']"));

                userName.SendKeys(TestAccounts.userName);
                password.SendKeys(TestAccounts.password);

                await Task.Delay(500);

                //Assert - Email and Password are not null and it redirects to home page
                Assert.IsNotNull(userName.Text);
                Assert.IsNotNull(password.Text);

                loginButton.Click();
                await Task.Delay(500);

                Assert.AreEqual(TestAccounts.homeUrl, driver.Url);

            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
