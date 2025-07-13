using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using saucedemo.Pages;

namespace saucedemo
{
    public class Tests
    {

        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
          /*  ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-gpu"); // Recomendado para compatibilidad
            options.AddArgument("--window-size=1920,1080"); // Simula una ventana visible
            options.AddUserProfilePreference("credentials_enable_service", false);
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
          */

            //_driver = new ChromeDriver();
            _driver = new EdgeDriver();
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            _driver.Manage().Window.Maximize();
                       

        }

        [Test]
        public void Test1()
        {
            var pagina_logueo = new login(_driver);
            pagina_logueo.logueo();


            var pagina_selec = new sel_productos(_driver);
            System.Threading.Thread.Sleep(5000);
            pagina_selec.espera_carga_sel();
            pagina_selec.Selecciona();

            var pagina_resumen = new resumen_input(_driver);
            pagina_resumen.espera_carga_resumen();
            System.Threading.Thread.Sleep(2000);
            pagina_resumen.presionacheckout();

            var pagina_verificar = new verificacion(_driver);
            pagina_verificar.espera_carga_verificar();
            pagina_verificar.presiona_continuar();
            System.Threading.Thread.Sleep(2000);

            var pagina_resfinal = new resumen_final(_driver);
            pagina_resfinal.espera_carga_refinal();
            pagina_resfinal.presiona_boton_final();
            System.Threading.Thread.Sleep(2000);

            var pagina_confirmacion = new confirma_exito(_driver);
            bool mivar = pagina_confirmacion.espera_carga_confirmacion();

            System.Threading.Thread.Sleep(3000);
            Assert.IsTrue(mivar);
            
        }


        [TearDown]
        public void cierratodo()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        
        }


    }
}