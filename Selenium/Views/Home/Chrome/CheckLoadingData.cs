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

namespace Selenium.Views.Home.Chrome
{
    [TestClass]
    public class CheckLoadingData
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\ccl002\source\repos\Clockwork-AWH\awhcode-clockwork-repo-a3b620f80baa\Selenium\bin\Debug\netcoreapp2.1");

        [TestMethod]
        public async Task AllElements_Appear_AllDataLoads_WhenButtons_Clicked()
        {
            try
            {
                //Test - Get current time works and data is loaded after button is clicked.
                driver.Navigate().GoToUrl(TestAccounts.homeUrl);
                await Task.Delay(500);
                Assert.AreEqual(TestAccounts.homeUrl, driver.Url);

                var getTimeButton = driver.FindElement(By.Id("reload"));
                var currentTimeTable = driver.FindElement(By.Id("clockworkBody"));

                getTimeButton.Click();
                await Task.Delay(500);
                Assert.IsNotNull(currentTimeTable.Text);

                //Test - Get All Entries in database panel works and loads all entries.
                var getAllPanel = driver.FindElement(By.XPath("//span[text()='Clockwork - All Entries (Click Me)']"));
                getAllPanel.Click();

                var getAllButton = driver.FindElement(By.Id("show"));
                var getAllTable = driver.FindElement(By.Id("getAllTable"));

                getAllButton.Click();
                await Task.Delay(500);

                Assert.IsTrue(getAllTable.Displayed);
                Assert.IsNotNull(getAllTable.Text);
                Assert.IsTrue(getAllTable.Enabled);


            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
