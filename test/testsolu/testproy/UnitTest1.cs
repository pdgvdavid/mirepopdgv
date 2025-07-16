using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace testproy
{
    public class Tests
    {
        private IWebDriver _driver; 
        [SetUp]
        public void Setup()
        {
            _driver = new EdgeDriver();
          //  _driver.Navigate().GoToUrl("http://localhost:8080/introduccion.html");
           // _driver.Navigate().GoToUrl("C:\\aCICD\\introduccion.html");
string path = Path.GetFullPath(@"../../../introduccion.html");
_driver.Navigate().GoToUrl("file:///" + path.Replace("\\", "/"));           
TestContext.WriteLine("Ruta HTML: " + path);
            //Console.WriteLine(_driver.PageSource);
            TestContext.WriteLine("=== PAGE SOURCE ===");
            TestContext.WriteLine(_driver.PageSource);
            TestContext.WriteLine("=== END PAGE SOURCE ===");
            _driver.Manage().Window.Maximize();
           
        }

        [Test]
        public void Test1()
        {
            bool flag = false;
//            System.Threading.Thread.Sleep(3000);
WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
wait.Until(driver => driver.FindElement(By.Id("multiplicando")));

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