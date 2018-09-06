using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Selenium.Constants
{
    public static class TestAccounts
    {
        public const string userName = "test@test.com";
        public const string password = "Test1234!";
        public const string loginUrl = "https://localhost:44306/Identity/Account/Login";
        public const string homeUrl = "https://localhost:44306/";
    }
}
