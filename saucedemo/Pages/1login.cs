using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saucedemo.Pages
{
    public class login
    {
        
        private IWebDriver _driver;
        IWebElement username => _driver.FindElement(By.Id("user-name"));
        IWebElement password => _driver.FindElement(By.Id("password"));

        IWebElement boton => _driver.FindElement(By.Id("login-button"));

        public login(IWebDriver driver)
        {
            _driver = driver; 
        
        }

        public void logueo()
        {
            username.SendKeys("visual_user");//  standard_user");
            password.SendKeys("secret_sauce");
            boton.Click();

        }

    }
}
