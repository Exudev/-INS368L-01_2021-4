using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemperaturesTest
{
    [TestClass]
    public class UnitTest1
    {
        //celsius
        [TestMethod]
        public void CelsiusAKelvinTest()
        {

            double kelvinDado = Temperature.Program.CelsiusAKelvin(2);
            double esperado =275.15;
            Assert.AreEqual(esperado,kelvinDado);
        }
        [TestMethod]
        public void CelsiusAfahrenheitTest()
        {

            double KelvinDado = Temperature.Program.CelsiusAFahrenheit(15);
            double esperado = 59;
            Assert.AreEqual(esperado, KelvinDado);
        }
        //kelvin
        [TestMethod]
        public void KelvinACelsiusTest()
        {

            double KelDado = Temperature.Program.KelvinACelsius(5);
            double esperado = -268.15;
            Assert.AreEqual(esperado, KelDado);
        }
        [TestMethod]
        public void KelvinAfahrenheitTest()
        {

            double KelDado = Temperature.Program.KelvinAFahrenheit(10);
            double esperado = -441.66999999999996;
            Assert.AreEqual(esperado, KelDado);
        }
        //fahrenheit
        [TestMethod]
        public void fahrenheitAKelvin()
        {

            double fahDado = Temperature.Program.FahrenheitAKelvin(32);
            double esperado = 273.15;
            Assert.AreEqual(esperado, fahDado);
        }
        [TestMethod]
        public void FahrenheitACelsiusTest()
        {

            double fahDado = Temperature.Program.FahrenheitACelsius(32);
            double esperado = 0.0;
            Assert.AreEqual(esperado, fahDado);
        }
    }
}
