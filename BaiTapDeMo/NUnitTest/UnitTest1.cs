using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        public PhoneBookList service;
        [TestMethod]
        public void TestMethod1()
        {
            service = new PhoneBookList();
        }
        public void AddPhoneTest_1()
        {
            service.InsertPhone("Khoa", "123");
            Assert.IsTrue(service.contacts.Count == 1);
        }
    }
}
