using NUnit.Framework;
using CurrencyTest;
using System;

namespace NUnitTestProject2
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void TestMulti()
        {
            Assert.AreEqual(10, Currency.Dollar(5).Times(2).Amount);
            Assert.AreEqual(0, Currency.Frank(0).Times(25).Amount);
            Assert.Throws<OverflowException>(() => Currency.Dollar(decimal.MaxValue).Times(2));
        }

        [Test]
        public void TestSum()
        {
            var sum = Currency.Dollar(5).Sum(Currency.Dollar(12));
            Assert.True(sum.Equal(Currency.Dollar(17)));

            var sum2 = Currency.Dollar(5).Sum(Currency.Frank(10));
            Assert.True(sum2.Equal(Currency.Dollar(10)));

            var sum3 = Currency.Dollar(5).Sum(Currency.Frank(10));
            Assert.True(sum3.Equal(Currency.Dollar(10)));
        }
    }
}