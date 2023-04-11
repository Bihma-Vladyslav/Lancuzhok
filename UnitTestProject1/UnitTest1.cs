using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lancuzhok;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodBank1()
        {
            Assert.AreEqual(1, 1, "error something1");
        }
    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethodBank2() { 
            //set the initial params
            BankHandler h1 = new PrivatBankHandler();
            BankHandler h2 = new SavingBankHandler();
            h1.setNext(h2);
            h1.request(new Card(1));
            Assert.AreEqual(1, c.type = 1, "error something2");
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethodBank3()
        {
            //set the initial params
            BankHandler h2 = new PrivatBankHandler();
            BankHandler h4 = new SavingBankHandler();
            h2.setNext(h4);
            h2.request(new Card(4));
            Assert.AreEqual(4, c.type = 2, "error something2");
        }
    }
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethodBank3()
        {
            //set the initial params
            BankHandler h2 = new PrivatBankHandler();
            BankHandler h4 = new SavingBankHandler();
            h2.setNext(h4);
            h2.request(new Card(4));
            Assert.AreEqual(4, c.type = 4, "error something2");
        }
    }
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethodBank4()
        {
            //set the initial params
            BankHandler h3 = new SenseBankHandler();
            BankHandler h4 = new MonoBankHandler();
            h3.setNext(h4);
            h3.request(new Card(4));
            Assert.AreNotEqual(3, c.type = 4, "error something2");
        }
    }
}
