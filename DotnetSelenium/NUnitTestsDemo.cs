using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{

    [TestFixture("textfixture")]
    public class NUnitTestsDemo
    {
        private IWebDriver _driver;
        private readonly string valor;

        public NUnitTestsDemo(string valor)
        {
            this.valor = valor;
        }



        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("C:\\vs\\vs2022\\mipagina.html");
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1_nunit()
        {

            


            IWebElement mielement = _driver.FindElement(By.Name("codigo"));
            IWebElement mielement2 = _driver.FindElement(By.Name("txtcodigo2"));
          mielement.SendKeys( "texto desde munittestsdemo");
            mielement2.SendKeys(valor);

           // WebDriverWait espera1 = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            //espera1.Until(dr => dr.FindElement(By.Name("tt")));
          Assert.Pass();
        }

        [TestCase("param1", "param2")]
        [Category("tipo1")]/// se ejecuta en el terminal asi: dotnet test --filter "Category=tipo1" 
        public void Test2_nunit(string par1, string par2) 
        {
            Console.WriteLine($"Los parametros ingresados son { par1} -- {par2}"); 
        }
        
        [TearDown]
        public void Libera_datos()
        {

            _driver.Quit();
            _driver.Dispose();
        }
        
    }
}
