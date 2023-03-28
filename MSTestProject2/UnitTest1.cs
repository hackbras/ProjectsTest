using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(2, 3);
        }

        [TestMethod]
        [DataRow(2)]
        [DataRow(5)]
        [DataRow(7)]
        public void Test2(int num)
        {
            Assert.AreNotEqual(num, 2);
        }
        [TestMethod]
        [DataRow(2)]
        [DataRow(7)]
        [DataRow(4)]
        public void Test3(int num)
        {
            Assert.AreNotSame("2", num);
        }
        [TestMethod]
        public void Test3()
        {
            Assert.AreSame("2", '2');
        }
        [TestMethod]
        public void Test4()
        {
            Assert.Equals(7 + 2, 17);
            Assert.Equals(7 + 10, 17);
            Assert.Equals(7 + 4, 17);
        }
        [TestMethod]
        public void Test5()
        {
            Assert.Fail("Wrong");
        }

        [TestMethod]
        public void Test6()
        {
            Assert.Inconclusive();
        }

        [TestMethod]
        public void Test7()
        {
            Assert.IsFalse(45 == 43);
        }

        [TestMethod]
        public void Test8()
        {
            Assert.IsNull(null);
        }
        [TestMethod]
        public void Test9()
        {
            Assert.IsTrue(45 >= 3);
        }
        [ClassInitialize]
        public static void InicializarClasse(TestContext context) { }

        [TestInitialize]
        public void InicializarTeste() { }

        [TestCleanup]
        public void FinalizarTeste() { }
        [ClassCleanup]
        public static void FinalizarClasse() { }
        
    }
}
