using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        
        [Test]
        public void Test1()
        {
            Assert.AreEqual(1,1);
        }

        [Test]
        [TestCase(2)]
        [TestCase(5)]
        [TestCase(7)]
        public void Test2(int num)
        {
            Assert.AreNotEqual(num,2);
        }
        [Test]

        [TestCase(2)]
        [TestCase(7)]
        [TestCase(4)]
        public void Test3(int num)
        {
            Assert.AreNotSame("2",num);
        }
        [Test]
        public void Test4()
        {
            Assert.AreSame("2",'2');
        }
        //[Test]
        //public void Test5()
        //{
        //    Assert.ByVal();
        //}
        //[Test]
        //public void Test6()
        //{
        //    Assert.Catch();
        //}
        //[Test]
        //public void Test7()
        //{
        //    Assert.Catch();
        //}
        //[Test]
        //public void Test8()
        //{
        //    Assert.Catch<>();
        //}

        //[Test]
        //public void Test9()
        //{
        //    Assert.CatchAsync();
        //}
        //[Test]
        //public void Test10()
        //{
        //    Assert.CatchAsync<>();
        //}
        [Test]
        public void Test11()
        {
            Assert.Contains(7,new[] {1,2,3 });
        }
        //[Test]
        //public void Test12()
        //{
        //    Assert.DoesNotThrow();
        //}
        //[Test]
        //public void Test13()
        //{
        //    Assert.DoesNotThrowAsync();
        //}
        [Test]
        public void Test14()
        {
            Assert.Equals(7+2,17);
        }
        [Test]
        public void Test15()
        {
            Assert.Fail("Wrong");
        }
        [Test]
        public void Test16()
        {
            Assert.False(7*2==14);
        }
        [Test]
        public void Test17()
        {
            Assert.Greater(7,2);
        }
        [Test]
        public void Test18()
        {
            Assert.GreaterOrEqual(7,8);
        }
        [Test]
        public void Test19()
        {
            Assert.Ignore();
        }
        [Test]
        public void Test20()
        {
            Assert.Inconclusive();
        }
        //[Test]
        //public void Test21()
        //{
        //    Assert.IsAssignableFrom();
        //}
        //[Test]
        //public void Test22()
        //{
        //    Assert.IsAssignableFrom<>();
        //}
        [Test]
        public void Test23()
        {
            Assert.IsEmpty("a");
        }
        [Test]
        public void Test24()
        {
            Assert.IsFalse(45==43);
        }
        //[Test]
        //public void Test25()
        //{
        //    Assert.IsInstanceOf();
        //}
        //[Test]
        //public void Test26()
        //{
        //    Assert.IsInstanceOf<>();
        //}
        //[Test]
        //public void Test27()
        //{
        //    Assert.IsInstanceOf<>();
        //}
        [Test]
        public void Test28()
        {
            Assert.IsNull(null);
        }
        [Test]
        public void Test29()
        {
            Assert.IsTrue(45>=3);
        }
        [Test]
        public void Test30()
        {
            Assert.Less(40,43);
        }
        [Test]
        public void Test31()
        {
            Assert.LessOrEqual(56-2,30);
        }
        //public void Test32()
        //{
        //    Assert.Multiple(14,7);
        //}
        [Test]
        public void Test33()
        {
            Assert.Negative(-4);
        }
        [Test]
        public void Test34()
        {
            Assert.NotNull("4");
        }
        [Test]
        public void Test35()
        {
            Assert.NotZero(0);
        }
        [Test]
        public void Test36()
        {
            Assert.Null(null);
        }
        [Test]
        public void Test37()
        {
            Assert.Pass();
        }
        [Test]
        public void Test38()
        {
            Assert.Positive(7);
        }
        //public void Test39()
        //{
        //    Assert.ReferenceEquals();
        //}
        [Test]
        public void Test40()
        {
            Assert.That(5+2==7);
        }
        //public void Test41()
        //{
        //    Assert.That<>();
        //}
        //public void Test42()
        //{
        //    Assert.Throws();
        //}

        //public void Test43()
        //{
        //    Assert.Throws<>();
        //}
        //public void Test44()
        //{
        //    Assert.ThrowsAsync();
        //}
        [Test]
        public void Test45()
        {
            Assert.True(5-2==3);
        }
        [Test]
        public void Test46()
        {
            Assert.Warn("ai");
        }
        [Test]
        public void Test47()
        {
            Assert.Zero(0);
        }
    }
}