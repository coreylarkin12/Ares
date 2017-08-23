using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Capstone.Classes;


namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineItemsTest
    {
        [TestMethod]
        public void NamePriceQuantity()
        {
            VendingMachineItem test = new VendingMachineItem("Corey", 1.50);
            VendingMachineItem test2 = new VendingMachineItem("Alex", 2.00);
            VendingMachineItem test3 = new VendingMachineItem("Jane", 5.00);

            int quantity = 1;
            int quantity2 = 5;
            int quantity3 = 10;

            test.Quantity = quantity;
            Assert.AreEqual(1, test.Quantity);

            test.Quantity = quantity2;
            Assert.AreEqual(5, test.Quantity);

            test.Quantity = quantity3;
            Assert.AreEqual(10, test.Quantity);

            Assert.AreEqual("Corey", test.Name);
            Assert.AreEqual(1.50, test.Price);

            Assert.AreEqual("Alex", test2.Name);
            Assert.AreEqual(2.00, test2.Price);

            Assert.AreEqual("Jane", test3.Name);
            Assert.AreEqual(5.00, test3.Price);
        }
    }
}
