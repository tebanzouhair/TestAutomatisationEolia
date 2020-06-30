using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace TestAutomatisationEolia
{
    class Program
    {

         string eolia_url = "https://cloud.eolia-software.com/Recrutement/";


         string account_name = "surveillance@eolia-software.com";

        string account_pswd = "1234";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //IWebDriver driver = new FirefoxDriver();
            IWebDriver driver = new ChromeDriver("C:\\Program Files (x86)\\Google\\Chrome\\Application\\");
            //ChromeOptions options = new ChromeOptions();

            //options.AddArguments("debuggerAddress", "localhost:9014");
            //options.BinaryLocation = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe";
            //options.AddArguments("--user-data-dir=C:\\Selenium\\chrome_Test");

            //driver = new ChromeDriver(options);


            driver.Url = "https://cloud.eolia-software.com/Recrutement/";
            System.Threading.Thread.Sleep(10000);

            IWebElement user = driver.FindElement(By.Id("MainContent_LoginUser_UserName_I"));
        user.Clear();
                user.SendKeys("surveillance@eolia-software.com");

                IWebElement pswd = driver.FindElement(By.Id("MainContent_LoginUser_Password_I"));
        pswd.Clear();
                pswd.SendKeys("1234");

                IWebElement btn_sign = driver.FindElement(By.Id("MainContent_LoginUser_LoginButton_CD"));
        btn_sign.Click();

    }
    }
}
