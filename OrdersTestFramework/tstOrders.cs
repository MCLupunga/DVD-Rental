
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
         public void StockIDOK()
         {
            //create an instance of the class 
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property 
            string TestData = "5678"; 
             //assign the data to the property 
             AnOrder.StockID = TestData; 
             //test to see that the two values are the same 
             Assert.AreEqual(AnOrder.StockID, TestData); 
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
        [TestMethod]
        public void TestOrderNoFound()
        {
            //create an instance 
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test to use with the method
            string OrderNo = "98765";
            //invoke the method 
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderNo != "98765") 
            {
                OK = false;
            }
            //test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            string OrderNo = "98765";
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the customer id
            if (AnOrder.CustomerID != "123456")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            string OrderNo = "98765";
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.StockID != "5678")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestExpectedReturnDateFound()
        {
            //create an instance
            clsOrders AnOrder = new clsOrders();
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            string OrderNo = "98765";
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.ExpectedReturnDate !=Convert.ToDateTime("26/01/2018"))
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void testOrderDateFound()
        {
            //create an instance
            clsOrders AnOrder = new clsOrders();
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            string OrderNo = "98765";
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.OrderDate != Convert.ToDateTime("12/01/2018"))
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPaymentMethodFound()
        {
            //create an instance
            clsOrders AnOrder = new clsOrders();
            //boolean to store the result of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK
            Boolean OK = true;
            //create some test data to use with the method
            string OrderNo = "98765";
            //invoke the method
            Found = AnOrder.Find(OrderNo);
            //check the property
            if (AnOrder.PaymentMethod != "Card")
            {
                OK = false;
            }
            //test to see the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = "12/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID,Expected_Return_Date,Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
    }     
 } 
