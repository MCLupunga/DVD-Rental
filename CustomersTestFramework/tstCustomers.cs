﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace CustomersTestFramework
{
    [TestClass]
    public class tstCustomers
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance
            clsCustomers ACustomer = new clsCustomers();
            //test to see if it exists
            Assert.IsNotNull(ACustomer);
        }
    }
}
