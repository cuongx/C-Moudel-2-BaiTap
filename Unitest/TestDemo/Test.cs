using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Test
{
    public class CalculatorTest
    {
        [TestClass]
        public class PrimeService_IsPrimeShould
        {
            private CalculatorService _calculatorService;

            [TestMethod]
            public void SetUp()
            {
                _calculatorService = new CalculatorService();
            }

            [Test]
            public void TestAdd0And0()
            {
                int first = 0;
                int second = 0;
                int expected = 0;

                int result = _calculatorService.Add(first, second);
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void TestAdd1And0()
            {
                int first = 1;
                int second = 0;
                int expected = 1;

                int result = _calculatorService.Add(first, second);
                Assert.AreEqual(expected, result);
            }

            [Test ]
            public void TestAdd0And1()
            {
                int first = 0;
                int second = 1;
                int expected = 1;

                int result = _calculatorService.Add(first, second);
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void TestAdd5And3()
            {
                int first = 5;
                int second = 3;
                int expected = 8;

                int result = _calculatorService.Add(first, second);
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void TestSub0and0()
            {
                int first = 0;
                int second = 0;
                int expected = 0;

                int result = _calculatorService.Sub(first, second);
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void TestSub1and0()
            {
                int first = 1;
                int second = 0;
                int expected = 1;

                int result = _calculatorService.Sub(first, second);
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void TestSub0and1()
            {
                int first = 0;
                int second = 1;
                int expected = -1;

                int result = _calculatorService.Sub(first, second);
                Assert.AreEqual(expected, result);
            }

            [Test]
            public void TestSub5and3()
            {
                int first = 5;
                int second = 3;
                int expected = 2;

                int result = _calculatorService.Sub(first, second);
                Assert.AreEqual(expected, result);
            }
        }
    }

    internal class CalculatorService
    {
        internal int Add(int first, int second)
        {
            throw new NotImplementedException();
        }

        internal int Sub(int first, int second)
        {
            throw new NotImplementedException();
        }
    }
}