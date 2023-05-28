using Microsoft.VisualStudio.TestTools.UnitTesting;
using Recursividade;

namespace UnitsRecursividade
{
    [TestClass]
    public class TestsRecursividade
    {
        Metodos? metodos;

        [TestInitialize]
        public void InitClasses()
        {
            metodos = new Metodos();
        }

        [TestMethod]
        public void TestFatorial()
        {
            Assert.AreEqual(metodos.CalcularFatorial(5), 120);
            Assert.AreEqual(metodos.CalcularFatorial(7), 5040);
            Assert.AreEqual(metodos.CalcularFatorial(9), 362880);
        }

        [TestMethod]
        public void TestPotencia()
        {
            Assert.AreEqual(metodos.CalcularPotencia(5, 3, 1), 125);
            Assert.AreEqual(metodos.CalcularPotencia(7, 4 ,1), 2401);
            Assert.AreEqual(metodos.CalcularPotencia(9, 4, 1), 6561);
        }

        [TestMethod]
        public void TestMediaNumeros()
        {

        }

        [TestMethod]
        public void TestSomatoriaNumeros()
        {

        }

        [TestMethod]
        public void TestCaracteresString()
        {

        }

        [TestMethod]
        public void TestInversaoString()
        {

        }

        [TestCleanup]
        public void DisposeClasses()
        {
            metodos = null;            
        }
    }
}