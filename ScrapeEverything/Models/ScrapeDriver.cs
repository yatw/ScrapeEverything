using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;

namespace ScrapeEverything.Models
{
    public class ScrapeDriver
    {

        PhantomJSDriverService service;
        PhantomJSOptions options;

        IWebDriver driver;

        public ScrapeDriver()
        {
            service = PhantomJSDriverService.CreateDefaultService();
            service.IgnoreSslErrors = true;
            service.LoadImages = false;
            service.ProxyType = "none";
            service.SslProtocol = "any";

            options = new PhantomJSOptions();
            options.AddAdditionalCapability("IsJavaScriptEnabled", true);

            driver = new PhantomJSDriver(service, options);
        }

        public int login(string userNameFieldId, string userName, string userPasswordFieldId, string userPassword, string btnValue)
        {

            try
            {
                var userNameField = driver.FindElement(By.Id(userNameFieldId));
                var userPasswordField = driver.FindElement(By.Id(userPasswordFieldId));
                var loginButton = driver.FindElement(By.XPath(String.Format("//input[@value='{0}']", btnValue)));
                userNameField.SendKeys(userName);
                userPasswordField.SendKeys(userPassword);
                loginButton.Click();
                return 1;
            }
            catch
            {
                return 3;
            }
 
        }


        public Response scrape(Page p)
        {
            Response response = new Response();

            if (p == null || p.url == null)
            {
                return response.setCode(0);
            }

            driver.Navigate().GoToUrl(p.url);

            // check if we navigate to the expected page
            // invalid url will get routed to "about:blank"
            if (driver.Url == "about:blank")
            {
                response.html = driver.Url;
                return response.setCode(2);;
            }

            if (p.requireLogin)
            {
                if (p.userNameFieldId == null || p.userPasswordFieldId == null || p.userName == null || p.userPassword == null || p.btnValue == null)
                {
                    return response.setCode(0);
                }
                int result = login(p.userNameFieldId, p.userName, p.userPasswordFieldId, p.userPassword, p.btnValue);
                if (result == 3)
                {
                    return response.setCode(3);
                }
            }
    

            response.html = driver.PageSource;
            response.setCode(1);
            return response;
        }
    }
}