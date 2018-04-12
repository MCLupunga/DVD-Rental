using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace OrdersTestFramework
{
    [TestClass]
    public class tstOrdersCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.StockID = "5678";
            TestItem.CustomerID = "123456";
            TestItem.OrderNo = "98765";
            TestItem.PaymentMethod = "Card";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ExpectedReturnDate = DateTime.Now.Date.AddDays(7);
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            //create an instance of the class we want to create 
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            clsOrders TestOrders = new clsOrders();
            //set the properties of the test object
            TestOrders.StockID = "5678";
            TestOrders.CustomerID = "123456";
            TestOrders.OrderNo = "98765";
            TestOrders.PaymentMethod = "Card";
            TestOrders.OrderDate = DateTime.Now.Date;
            TestOrders.ExpectedReturnDate = DateTime.Now.Date.AddDays(7);
            //assign the data to the property
            AllOrders.ThisOrder = TestOrders;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.ThisOrder, TestOrders);
        }
        [TestMethod]
        public void ListandCountOK()
        {
            //create an instance of the class we want to create
            clsOrdersCollection AllOrders = new clsOrdersCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrders> TestList = new List<clsOrders>();
            //add an item to the list
            //create the item of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.StockID = "5678";
            TestItem.CustomerID = "123456";
            TestItem.OrderNo = "98765";
            TestItem.PaymentMethod = "Card";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ExpectedReturnDate = DateTime.Now.Date.AddDays(7);
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

    }

}
