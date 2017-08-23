using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Capstone.Classes;

namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        
        [TestMethod]
        public void Balance()
        {
            VendingMachine test = new VendingMachine();
            double balance = 3.50;
            double balance2 = 0.25;
            double balance3 = 1.75;

            test.Balance = balance;
            Assert.AreEqual(3.50, test.Balance);
            test.Balance = balance2;
            Assert.AreEqual(0.25, test.Balance);
            test.Balance = balance3;
            Assert.AreEqual(1.75, test.Balance);
        }
        [TestMethod]
        public void FeedMoney()
        {
            VendingMachine test = new VendingMachine();

            test.FeedMoney(10);
            Assert.AreEqual(10.00, test.Balance);

            test.FeedMoney(5);
            Assert.AreEqual(15.00, test.Balance);
        }
        [TestMethod]
        public void SelectProduct()
        {
            Dictionary<string, VendingMachineItem> testAllItems = new Dictionary<string, VendingMachineItem>();
            VendingMachine test = new VendingMachine();
            VendingMachineItem testItem = new VendingMachineItem("Potato Crisps", 3.05);
            testAllItems.Add("A1", testItem);

            test.AllItems = testAllItems;
            int result = test.SelectProduct("A1");
            Assert.AreEqual(2, result);

            test.FeedMoney(10);
            result = test.SelectProduct("A1");
            Assert.AreEqual(1, result);

            result = test.SelectProduct("Garbage");
            Assert.AreEqual(-1, result);

            testItem.Quantity = 0;
            result = test.SelectProduct("A1");
            Assert.AreEqual(0, result);

        }
        [TestMethod]
        public void MakeChange()
        {
            VendingMachine test = new VendingMachine();

            test.Balance = 10.00;
            int[] result = test.MakeChange();
            CollectionAssert.AreEqual(new int[] { 40, 0, 0 }, result);

            test.Balance = 6.05;
            result = test.MakeChange();
            CollectionAssert.AreEqual(new int[] { 24, 0, 1 }, result);

            test.Balance = 0.40;
            result = test.MakeChange();
            CollectionAssert.AreEqual(new int[] { 1, 1, 1 }, result);
        }

    }
}
