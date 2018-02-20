
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace OrdersTestFramework
 { 
     [TestClass] 
     public class tstOrders     { 
         [TestMethod] 
         public void InstanceOK()
         { 
             //create a new instance 
             clsOrders AnOrder = new clsOrders(); 
             //test to see that the class exists 
             Assert.IsNotNull(AnOrder); 
         } 
        [TestMethod] 
         public void CustomerIDOK()
         { 
             //create an instance of the class 
             clsOrders AnOrder = new clsOrders(); 
             //create some test data to assign to the property 
             string TestData = "123456"; 
             //assign the data to the property 
             AnOrder.CustomerID = TestData; 
             //test to see that the two values are the same 
             Assert.AreEqual(AnOrder.CustomerID, TestData); 
         } 
         [TestMethod] 
         public void DVDIDOK()
         {
            //create an instance of the class 
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property 
            string TestData = "5678"; 
             //assign the data to the property 
             AnOrder.DVDID = TestData; 
             //test to see that the two values are the same 
             Assert.AreEqual(AnOrder.DVDID, TestData); 
         } 
         [TestMethod] 
         public void ExpectedReturnDateOK()
         {
            //create an instance of the class 
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date.AddDays(+14);
            //assign the data to the property 
            AnOrder.ExpectedReturnDate = TestData; 
             //test to see that the two values are the same 
             Assert.AreEqual(AnOrder.ExpectedReturnDate, TestData); 
         } 
         [TestMethod] 
         public void OrderDateOK()
         {
            //create an instance of the class 
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property 
            DateTime TestData = DateTime.Now.Date; 
             //assign the data to the property 
             AnOrder.OrderDate = TestData; 
             //test to see that the two values are the same 
             Assert.AreEqual(AnOrder.OrderDate, TestData); 
        } 
         [TestMethod] 
         public void OrderNoOK()
         {
            //create an instance of the class 
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property 
            string TestData = "98765"; 
             //assign the data to the property 
             AnOrder.OrderNo = TestData; 
             //test to see that the two values are the same 
             Assert.AreEqual(AnOrder.OrderNo, TestData); 
         } 
        [TestMethod] 
         public void PaymentMethodOK()
         {
            //create an instance of the class 
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property 
            string TestData = "card"; 
             //assign the data to the property 
             AnOrder.PaymentMethod = TestData; 
             //test to see that the two values are the same 
             Assert.AreEqual(AnOrder.PaymentMethod, TestData); 
         } 
         [TestMethod] 
        public void FindMethodOK()
        {
            //create an instance of the class 
            clsOrders AnOrder = new clsOrders();
            //Boolean variable to store the result of the validation 
            Boolean Found = false; 
             //create some test data to use with the method 
             string OrderNo = "98765"; 
             //invoke the method 
             Found = AnOrder.Find(OrderNo); 
            //test to see that the result is correct 
             Assert.IsTrue(Found); 
         } 
     }     
 } 
