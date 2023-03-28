using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        //[Fact]
        //public void Test1()
        //{
        //    Assert.All<string>(new List<string>() { "2","3"},Action<string a>);

        //}
        //[Fact]
        //public void Test2()
        //{
        //    Assert.Collection<>();

        //}
        [Fact]
        public void Test3()
        {
            Assert.Contains("@","a@out.com.br");

        }
        //[Fact]
        //public void Test4()
        //{
        //    Assert.Contains<>();

        //}
        [Fact]
        public void Test5()
        {
            Assert.DoesNotContain("@outlook.com", "hackbras@outlook.com");

        }
        //[Fact]
        //public void Test6()
        //{
        //    Assert.DoesNotContain<>();

        //}
        [Fact]
        public void Test7()
        {
            Assert.DoesNotMatch("@outlook.com","hackbras@outlook.com");

        }
        [Fact]
        public void Test8()
        {
            Assert.Empty(string.Empty);

        }
        [Fact]
        public void Test9()
        {
            Assert.EndsWith("eef","f");

        }
        [Fact]
        public void Test10()
        {
            Assert.Equal(3,4);

        }
        //[Fact]
        //public void Test11()
        //{
        //    Assert.Equal<>();

        //}
        [Fact]
        public void Test12()
        {
            Assert.False(2<3);

        }
        //[Fact]
        //public void Test13()
        //{
        //    Assert.InRange<>();

        //}
        //[Fact]
        //public void Test14()
        //{
        //    Assert.IsAssignableFrom();

        //}
        //[Fact]
        //public void Test15()
        //{
        //    Assert.IsAssignableFrom<>();

        //}
        //[Fact]
        //public void Test16()
        //{
        //    Assert.IsNotType();

        //}
        [Fact]
        public void Test17()
        {
            Assert.IsNotType<string>("2");

        }
        //[Fact]
        //public void Test18()
        //{
        //    Assert.IsType();

        //}
        //[Fact]
        //public void Test19()
        //{
        //    Assert.IsType<>();

        //}
        [Fact]
        public void Test20()
        {
            Assert.Matches("@a.com","tete@.com");

        }

        [Fact]
        public void Test21()
        {
            Assert.NotEmpty(string.Empty);

        }
        [Fact]
        public void Test22()
        {
            Assert.NotEqual(2,4);

        }
        //[Fact]
        //public void Test23()
        //{
        //    Assert.NotEqual<>();

        //}
        //[Fact]
        //public void Test24()
        //{
        //    Assert.NotInRange<>();

        //}
        [Fact]
        public void Test25()
        {
            Assert.NotNull(null);

        }
        [Fact]
        public void Test26()
        {
            Assert.NotSame(2,"2");

        }
        //[Fact]
        //public void Test27()
        //{
        //    Assert.NotStrictEqual<>();

        //}
        [Fact]
        public void Test28()
        {
            Assert.Null(true);

        }
        //[Fact]
        //public void Test29()
        //{
        //    Assert.ProperSubset<>();

        //}
        //[Fact]
        //public void Test30()
        //{
        //    Assert.ProperSuperset<>();

        //}
        //[Fact]
        //public void Test31()
        //{
        //    Assert.PropertyChanged();

        //}
        //[Fact]
        //public void Test32()
        //{
        //    Assert.PropertyChangedAsync();

        //}
        //[Fact]
        //public void Test33()
        //{
        //    Assert.Raises<>();

        //}
        //[Fact]
        //public void Test34()
        //{
        //    Assert.RaisesAny<>();

        //}
        //[Fact]
        //public void Test35()
        //{
        //    Assert.RaisesAnyAsync<>();

        //}
        //[Fact]
        //public void Test36()
        //{
        //    Assert.RaisesAsync<>();

        //}
        //[Fact]
        //public void Test37()
        //{
        //    Assert.ReferenceEquals();

        //}
        [Fact]
        public void Test38()
        {
            Assert.Same("ew","we");

        }
        //[Fact]
        //public void Test39()
        //{
        //    Assert.Single();

        //}
        //[Fact]
        //public void Test40()
        //{
        //    Assert.Single<>();

        //}
        [Fact]
        public void Test41()
        {
            Assert.StartsWith("abacaxi","aba");

        }
        //[Fact]
        //public void Test42()
        //{
        //    Assert.StrictEqual<>();

        //}
        //[Fact]
        //public void Test43()
        //{
        //    Assert.Subset<>();

        //}
        //[Fact]
        //public void Test44()
        //{
        //    Assert.Superset<>();

        //}
        //[Fact]
        //public void Test45()
        //{
        //    Assert.Throws();

        //}
        //[Fact]
        //public void Test46()
        //{
        //    Assert.Throws<>();

        //}
        //[Fact]
        //public void Test47()
        //{
        //    Assert.ThrowsAny<>();

        //}
        //[Fact]
        //public void Test48()
        //{
        //    Assert.ThrowsAnyAsync<>();

        //}
        //[Fact]
        //public void Test49()
        //{
        //    Assert.ThrowsAsync();

        //}
        //[Fact]
        //public void Test50()
        //{
        //    Assert.ThrowsAsync<>();

        //}
        [Fact]
        public void Test51()
        {
            Assert.True(70/2==1);

        }
    }
}
