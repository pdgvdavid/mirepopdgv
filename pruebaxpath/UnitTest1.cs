using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.ComponentModel;

namespace pruebaxpath
{
    public class Tests
    {
        private IWebDriver _driver;


        [SetUp]
        public void Setup()
        {

            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://demoqa.com/");
            _driver.Manage().Window.Maximize();

        }


        /*
        IWebElement campo_estado = _driver.FindElement(By.Id("state"));
        System.Threading.Thread.Sleep(5000);

        campo_estado.Click();

        IWebElement opcion_elegida = _driver.FindElement(By.XPath("//div[text()='Rajasthan']"));

        opcion_elegida.Click();
        */

        [Test]
        public void Test1()
        {

            /*   WebDriverWait espera = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
          IWebElement opcion_alerta1 = espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[text()='Alerts']")));
          opcion_alerta1.Click();
       */
            //js1.ExecuteScript("arguments[0].click();", opcion_alerta1);

            IJavaScriptExecutor js1 = (IJavaScriptExecutor)_driver;

            IWebElement botonForm1 = _driver.FindElement(By.XPath("//h5[text()='Forms']"));
            botonForm1.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement botonpracticeform = _driver.FindElement(By.XPath("//span[text()='Practice Form']"));
            botonpracticeform.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement nombre = _driver.FindElement(By.Id("firstName"));
            nombre.SendKeys("percy");
            IWebElement apellido = _driver.FindElement(By.Id("lastName"));
            apellido.SendKeys("diaz");
            IWebElement correo = _driver.FindElement(By.Id("userEmail"));
            correo.SendKeys("pdiaz@correo.com");
            IWebElement genero = _driver.FindElement(By.XPath("//label[contains(text(), 'Male')]"));
            genero.Click();
            IWebElement movil = _driver.FindElement(By.Id("userNumber"));
            movil.SendKeys("9478964866");
            IWebElement fechanac = _driver.FindElement(By.Id("dateOfBirthInput"));
            js1.ExecuteScript("document.getElementById('dateOfBirthInput').value = '26 Jun 2025'");
            IWebElement tema = _driver.FindElement(By.Id("subjectsInput"));
            tema.SendKeys("mitema");
            IWebElement pasatiempo = _driver.FindElement(By.XPath("//label[contains(text(),'Reading')]"));
            pasatiempo.Click();
            IWebElement direccion = _driver.FindElement(By.Id("currentAddress"));
            direccion.SendKeys("mi direccion");
            js1.ExecuteScript("window.scrollBy(0, 500);");
            IWebElement comboestado = _driver.FindElement(By.Id("state"));
            comboestado.Click();

            IWebElement opcionescogida = _driver.FindElement(By.XPath("//div[text()='Uttar Pradesh']"));
            opcionescogida.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement combociudad = _driver.FindElement(By.Id("city"));
            combociudad.Click();
            IWebElement opcionescogida2 = _driver.FindElement(By.XPath("//div[text()='Lucknow']"));
            opcionescogida2.Click();


            System.Threading.Thread.Sleep(3000);

            //pestaña Alerts, frame & windows 
            IWebElement opcion_alerts = _driver.FindElement(By.XPath("//div[contains(text(), 'Alerts, Frame & Windows')]"));
            opcion_alerts.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement opcion_alerta1 = _driver.FindElement(By.XPath("//span[text()='Alerts']"));
            opcion_alerta1.Click();

       
            System.Threading.Thread.Sleep(1000);

            //pestaña Elements 
            IWebElement opcionElements = _driver.FindElement(By.XPath("//div[contains(text(),'Elements')]"));
            opcionElements.Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement opcionwebtables = _driver.FindElement(By.XPath("//span[text()='Web Tables']"));
            opcionwebtables.Click();
            System.Threading.Thread.Sleep(2000);

            IWebElement cuadrobusqueda = _driver.FindElement(By.Id("searchBox"));
            cuadrobusqueda.SendKeys("vega");
            System.Threading.Thread.Sleep(1000);

            IWebElement tabradiobutton = _driver.FindElement(By.XPath("//span[text()='Radio Button']"));
            tabradiobutton.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement opcionradio = _driver.FindElement(By.XPath("//label[contains(text(), 'Impressive')]"));
            opcionradio.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement tabcheckbox = _driver.FindElement(By.XPath("//span[text()='Check Box']"));
            tabcheckbox.Click();
            System.Threading.Thread.Sleep(1000);


            IWebElement punteroarbol = _driver.FindElement(By.ClassName("rct-collapse-btn"));
            punteroarbol.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement puntero2 = _driver.FindElement(By.XPath("//span[text()='Documents']/parent::label/parent::span/button"));
            puntero2.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement puntero3 = _driver.FindElement(By.XPath("//span[text()='Office']/parent::label/parent::span/button"));

            puntero3.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement puntero4 = _driver.FindElement(By.XPath("//span[text()='Classified']"));
            puntero4.Click();

            System.Threading.Thread.Sleep(1000);

            
            //cierra pestaña Elements 
            opcionElements.Click();

            //pestaña widgets
            IWebElement tabwidgets = _driver.FindElement(By.XPath("//div[contains(text(),'Widgets')]"));
            System.Threading.Thread.Sleep(1000);
            tabwidgets.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement opcionfecha = _driver.FindElement(By.XPath("//span[text()='Date Picker']"));
            opcionfecha.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement campofecha = _driver.FindElement(By.Id("datePickerMonthYearInput"));
            //campofecha.SendKeys("05/25/2025");
            js1.ExecuteScript("document.getElementById('datePickerMonthYearInput').value = '05/25/2025'");
            System.Threading.Thread.Sleep(2000);
            js1.ExecuteScript("window.scrollBy(0, 500);");

            IWebElement opcionselectmenu = _driver.FindElement(By.XPath("//span[text()='Select Menu']"));
            opcionselectmenu.Click();
            System.Threading.Thread.Sleep(1000);

            //IWebElement combo1 = _driver.FindElement(By.XPath("//div[@class=' css-2b097c-container']"));
            //IWebElement combo1 = _driver.FindElement(By.XPath("//div[@class=' css-yk16xz-control']"));
            IWebElement combo1 = _driver.FindElement(By.XPath("//div[@class=' css-1hwfws3']"));
            combo1.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement opcioncombo = _driver.FindElement(By.XPath("//div[contains(text(), 'Group 2, option 1')]"));
            opcioncombo.Click();


            SelectElement miopci = new SelectElement(_driver.FindElement(By.Id("oldSelectMenu")));
            miopci.SelectByText("Yellow");
            System.Threading.Thread.Sleep(1000);

            js1.ExecuteScript("window.scrollBy(0, 500);");

            IWebElement msopcion = _driver.FindElement(By.XPath("//div[contains(text(),'Select...')]"));
            msopcion.Click();

            IWebElement msopcion2 = _driver.FindElement(By.XPath("//div[contains(text(), 'Black' )]"));
            msopcion2.Click();

            

            SelectElement smselect = new SelectElement(_driver.FindElement(By.Id("cars")));
            smselect.SelectByValue("audi");

            System.Threading.Thread.Sleep(5000);
            /*
            WebDriverWait espera = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            IWebElement opcionwebtables = espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath("//span[contains(text(),'Elements')]")));
            opcionwebtables.Click();
            */
            //            IWebElement opcionwebtables = _driver.FindElement(By.XPath("//span[contains(text(), 'Elements')]/ancestor::div[@class='header-wrapper']"));
            //System.Threading.Thread.Sleep(1000);
            ////ancestor::div[@class='contenedor'









            Assert.Pass();
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