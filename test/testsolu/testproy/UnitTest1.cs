using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace testproy
{
    public class Tests
    {
        private IWebDriver _driver; 
        [SetUp]
        public void Setup()
        {
            _driver = new EdgeDriver();
            _driver.Navigate().GoToUrl("C:\\aCICD\\introduccion.html");
            _driver.Manage().Window.Maximize();
           
        }

        [Test]
        public void Test1()
        {
            bool flag = false;
            IWebElement input1 = _driver.FindElement(By.Id("multiplicando"));
            IWebElement input2 = _driver.FindElement(By.Id("multiplicador"));
            IWebElement botoncalcula = _driver.FindElement(By.Id("btnproducto"));
            IWebElement fieldproducto = _driver.FindElement(By.Id("producto"));
            
            input1.SendKeys("5");
            input2.SendKeys("6");
            botoncalcula.Click();
            System.Threading.Thread.Sleep(3000);

            //if (fieldproducto.Text == "30")
            if (fieldproducto.GetAttribute("value") == "30")

            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            Assert.IsTrue(flag);


           
            
        }

        [TearDown]
        public void cerrar()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            
            }
        }






    }
}