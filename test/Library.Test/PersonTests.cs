using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void TestCedula1()
        {
            // Pruebo si cedula es null
            string cedula = "";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula2()
        {
            // Pruebo si cedula tiene más números de los que debería
            string cedula = "522716195";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula3()
        {
            // Pruebo con cedula invalida
            string cedula = "12345678";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula4()
        {
            // Pruebo si cedula tiene menos numeros de los que deberia
            string cedula = "5227161";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula5()
        {
            // Pruebo con letras en lugar de números
            string cedula = "abcdefgh";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula6()
        {
            // Pruebo con una cédula correcta
            string cedula = "52271619";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula7()
        {
            // Pruebo los puntos y guiones
            string cedula = "5.227.161-9";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula8()
        {
            // Pruebo los puntos y guiones
            string cedula = "5227.161-9";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void TestCedula9()
        {
            // Pruebo los puntos y guiones
            string cedula = "5227161-9";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula10()
        {
            // Pruebo los puntos y guiones
            string cedula = "5.227161-9";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula11()
        {
            // Pruebo los puntos y guiones
            string cedula = "5227161-9";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestCedula12()
        {
            // Pruebo los puntos y guiones
            string cedula = "5.227.1619";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestNombre1()
        {
            // Pruebo si el nombre es null
            Person pruebaNombre = new Person("", "52271619");
            string actual = pruebaNombre.Name;
            string expected = null;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestNombre2()
        {
            // Pruebo si el nombre es valido
            Person pruebaNombre = new Person("Ricardo", "52271619");
            string actual = pruebaNombre.Name;
            string expected = "Ricardo";
            Assert.AreEqual(expected, actual);
        }

    }
}