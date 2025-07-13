using demoproject.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace demoproject
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
           
            //IWebDriver driver = new ChromeDriver();
            var pagina_1 = new pagina1(driver);
            pagina_1.muestra_solo_notebooks();

            pagina_1.seleccionar_vaio7();

            var pagina_2 = new pagina2(driver);
            pagina_2.presiona_boton_adiciona_cart();

            //System.Threading.Thread.Sleep(3000);
            pagina_2.presiona_boton_confirmacion_Exito();

            var aparece_registro = pagina_2.presiona_menu_grabados();
            Assert.IsTrue(aparece_registro);

        }

        [TearDown]
        public void Cierratodo()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
            
            
        }
    }
}