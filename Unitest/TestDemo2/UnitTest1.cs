using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace TestDemo2
{
    [TestClass]
    public class Calculator_Add
    {
        private Calculator _calculator;

        [Test]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
       
            public void TestAdd()
            {
                int x = 1;
                int y = 1;
                int expResult = 2;
                int result = _calculator.Add(x, y);
                Assert.AreEqual(expResult, result);
            }

        [Test]
        public void TestAdd2()
        {
            int x = int.MaxValue;
            int y = 1;
            try
            {
                int result = _calculator.Add(x, y);
                Assert.IsFalse(true);
            }
            catch (Exception )
            {
                Assert.IsTrue(true);
            }
        }

        [Test]
        public void TestAdd3()
        {
            int x = int.MinValue;
            int y = -1;
            try
            {
                int result = _calculator.Add(x, y);
                Assert.IsFalse(true);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        private class Calculator
        {
            internal int Add(int x, int y)
            {
                throw new NotImplementedException();
            }
        }
    }
}
