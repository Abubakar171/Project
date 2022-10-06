using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Project_proposal
{
    [TestClass]
    public class UnitTest1
    {
        ChromeOptions options = new ChromeOptions();
        [TestMethod]
        public void SignUpWithInvalidCredentials()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[6]/a")).Click();
            driver.FindElement(By.Id("firstname")).SendKeys("......");
            driver.FindElement(By.Id("lastname")).SendKeys(",,,");
            driver.FindElement(By.Id("email_address")).SendKeys("abcd@xyz.com");
            driver.FindElement(By.Id("password")).SendKeys("!@#$");
            driver.FindElement(By.Id("password-confirmation")).SendKeys("!@#$");
            driver.FindElement(By.Id("assistance_allowed_checkbox")).Click();
            driver.FindElement(By.Id("cnic")).SendKeys("1234567891234");
            driver.FindElement(By.Id("tel_no")).SendKeys("01111111111");
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/form/div/div[1]/button")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[6]/a")).Click();
            driver.Close();

        }
        [TestMethod]
        public void SignUpWithInValidpassord()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[6]/a")).Click();
            driver.FindElement(By.Id("firstname")).SendKeys("Abubakar");
            driver.FindElement(By.Id("lastname")).SendKeys("Javaid");
            driver.FindElement(By.Id("email_address")).SendKeys("abubakarjavaid@ymail.com");
            driver.FindElement(By.Id("password")).SendKeys("123456789");
            driver.FindElement(By.Id("password-confirmation")).SendKeys("123456789");
            driver.FindElement(By.Id("assistance_allowed_checkbox")).Click();
            driver.FindElement(By.Id("cnic")).SendKeys("1234567891234");
            driver.FindElement(By.Id("tel_no")).SendKeys("03111111111");
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/form/div/div[1]/button")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[6]/a")).Click();
            driver.Close();

        }
        [TestMethod]
        public void SignUpInvalidnumericData()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[6]/a")).Click();
            driver.FindElement(By.Id("firstname")).SendKeys("112233");
            driver.FindElement(By.Id("lastname")).SendKeys("445566");
            driver.FindElement(By.Id("email_address")).SendKeys("22@ymail.com");
            driver.FindElement(By.Id("password")).SendKeys("1111....11");
            driver.FindElement(By.Id("password-confirmation")).SendKeys("1111....11");
            driver.FindElement(By.Id("assistance_allowed_checkbox")).Click();
            driver.FindElement(By.Id("cnic")).SendKeys("1234567891234");
            driver.FindElement(By.Id("tel_no")).SendKeys("03111111111");
            Thread.Sleep(10000);
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/form/div/div[1]/button")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[6]/a")).Click();
            driver.Close();

        }
        [TestMethod]
        public void SignUpWithValidCredentials()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[6]/a")).Click();
            driver.FindElement(By.Id("firstname")).SendKeys("Abubakar");
            driver.FindElement(By.Id("lastname")).SendKeys("Javaid");
            driver.FindElement(By.Id("email_address")).SendKeys("abubakarjavaid@ymail.com");
            driver.FindElement(By.Id("password")).SendKeys("Abubakar@1234");
            driver.FindElement(By.Id("password-confirmation")).SendKeys("Abubakar@1234");
            driver.FindElement(By.Id("assistance_allowed_checkbox")).Click();
            driver.FindElement(By.Id("cnic")).SendKeys("3820197930007");
            driver.FindElement(By.Id("tel_no")).SendKeys("03027055668");
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/form/div/div[1]/button")).Click();
            driver.Close();
        }
        [TestMethod]
        public void SigninwithValidCredentials()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/div[3]/div[1]/div[2]/div/div[1]/button")).Click();
            driver.FindElement(By.Id("inputEmail")).SendKeys("abubakarjavaid@ymail.com");
            driver.FindElement(By.Id("inputPassword")).SendKeys("Abubakar@1234");
            driver.FindElement(By.XPath("/html/body/div/div/div/form/button")).Click();
            driver.Close();

        }
        [TestMethod]
        public void SigninWithnoEmail()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/div[3]/div[1]/div[2]/div/div[1]/button")).Click();
            driver.FindElement(By.Id("inputEmail")).SendKeys("");
            driver.FindElement(By.Id("inputPassword")).SendKeys("Abubakar@1234");
            driver.FindElement(By.XPath("/html/body/div/div/div/form/button")).Click();
            driver.Close();

        }
        [TestMethod]
        public void SignInWithNoPassword()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/div[3]/div[1]/div[2]/div/div[1]/button")).Click();
            driver.FindElement(By.Id("inputEmail")).SendKeys("abubakarjavaid@ymail.com");
            driver.FindElement(By.Id("inputPassword")).SendKeys("");
            driver.FindElement(By.XPath("/html/body/div/div/div/form/button")).Click();
            driver.Close();

        }
        [TestMethod]
        public void SignInWithWrongPassword()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[1]/ul/li[5]/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/div[3]/div[1]/div[2]/div/div[1]/button")).Click();
            driver.FindElement(By.Id("inputEmail")).SendKeys("abubakarjavaid@ymail.com");
            driver.FindElement(By.Id("inputPassword")).SendKeys("123456789");
            driver.FindElement(By.XPath("/html/body/div/div/div/form/button")).Click();
            driver.Close();

        }
        [TestMethod]
        public void AddtoCartScenarioQLED()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html/body/div[7]/div[2]/div/div/div[2]/div/a")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div[1]/div[3]/div[2]/ol/li[3]/div/div[2]/div[2]/div/div/form/button")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/div[3]/form/div[1]/table/tbody/tr[1]/td[3]/div/div[2]/a[1]/i")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[3]/div/div[3]/div[1]/ul/li/button")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.Id("customer-email")).SendKeys("abubakarjavaiad@ymail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();
            driver.FindElement(By.Name("firstname")).SendKeys("Abubakar");
            driver.FindElement(By.Name("lastname")).SendKeys("Javaid");
            driver.FindElement(By.Name("company")).SendKeys("Contour software");
            driver.FindElement(By.Name("street[0]")).SendKeys("Lahore");
            // Dropdown
            var element = driver.FindElement(By.XPath("/html/body/div[7]/main/div[2]/div/div[3]/div[4]/ol/li[1]/div[2]/form[2]/div/div[5]/div/select"));
            var selectdropdown = new SelectElement(element);
            selectdropdown.SelectByText("KHUSHAB");

            driver.FindElement(By.Name("city")).SendKeys("khushab");
            driver.FindElement(By.Name("postcode")).SendKeys("41000");
            driver.FindElement(By.Name("telephone")).SendKeys("03027055668");
            driver.FindElement(By.CssSelector("#checkout-shipping-method-load > table > tbody > tr > td:nth-child(1) > input")).Click();
            driver.FindElement(By.Name("ko_unique_1")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[2]/div/div[3]/div[4]/ol/li[2]/div/div[3]/form/div[3]/div/button")).Click();
            Thread.Sleep(5000);
            // driver.FindElement(By.CssSelector("#cashondelivery")).Click();
            // driver.FindElement(By.XPath("//*[@id='cashondelivery']")).Click();
            // driver.FindElement(By.Name("payment[method]")).Click();
            driver.FindElement(By.XPath("/html/body/div[8]/main/div[2]/div/div[3]/div[4]/ol/li[3]/div/form/fieldset/div[1]/div/div/div[9]/div[1]/input")).Click();
            driver.FindElement(By.CssSelector("#billing-address-same-as-shipping-cashondelivery")).Click();
            driver.FindElement(By.Id("billing-address-same-as-shipping-cashondelivery")).Click();
            driver.FindElement(By.CssSelector("#billing-address-same-as-shipping-cashondelivery")).Click();
            driver.Close();

        }
        [TestMethod]
        public void AddtoCartScenarioAC()
        {
            options.AddArguments("disable-popup-blocking");
            IWebDriver driver = new ChromeDriver(options);
            driver.Url = "https://www.tclpakistan.com/";
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.FindElement(By.Id("pa-deny-btn")).Click();

            //Actions
            var element = driver.FindElement(By.XPath("/html/body/div[7]/header/div/div/div[2]/div[2]/div/div/div[2]/nav/ul/li[2]/a"));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();

            driver.FindElement(By.XPath("//a[@title='Elite']")).Click();
            //driver.FindElement(By.XPath("//button[@title='Add to Cart' and @class='action tocart primary']")).Click();
            driver.FindElement(By.XPath("//*[@id='layer-product-list']/div[2]/ol/li[2]/div/div[2]/div[2]/div/div/form/button")).Click();
            driver.FindElement(By.XPath("//*[@id='maincontent']/div[3]/div/div[3]/div[1]/ul/li/button")).Click();
            driver.FindElement(By.Id("customer-email")).SendKeys("abubakarjavaiad@ymail.com");
            Thread.Sleep(2000);
            driver.FindElement(By.Name("firstname")).SendKeys("Abubakar");
            driver.FindElement(By.Name("lastname")).SendKeys("Javaid");
            driver.FindElement(By.Name("company")).SendKeys("Contour software");
            driver.FindElement(By.Name("street[0]")).SendKeys("Lahore");
            var element1 = driver.FindElement(By.XPath("/html/body/div[7]/main/div[2]/div/div[3]/div[4]/ol/li[1]/div[2]/form[2]/div/div[5]/div/select"));
            var selectdropdown = new SelectElement(element1);
            selectdropdown.SelectByText("KHUSHAB");
            driver.FindElement(By.Name("city")).SendKeys("khushab");
            driver.FindElement(By.Name("postcode")).SendKeys("41000");
            driver.FindElement(By.Name("telephone")).SendKeys("03027055668");
            driver.FindElement(By.CssSelector("#checkout-shipping-method-load > table > tbody > tr > td:nth-child(1) > input")).Click();
            driver.FindElement(By.Name("ko_unique_1")).Click();
            driver.FindElement(By.XPath("/html/body/div[7]/main/div[2]/div/div[3]/div[4]/ol/li[2]/div/div[3]/form/div[3]/div/button")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("/html/body/div[8]/main/div[2]/div/div[3]/div[4]/ol/li[3]/div/form/fieldset/div[1]/div/div/div[9]/div[1]/input")).Click();
            driver.FindElement(By.CssSelector("#billing-address-same-as-shipping-cashondelivery")).Click();
            driver.FindElement(By.Id("billing-address-same-as-shipping-cashondelivery")).Click();
            driver.FindElement(By.CssSelector("#billing-address-same-as-shipping-cashondelivery")).Click();
            driver.Close();
        }
    }
}
