
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace OrdersTestFramework
{
    [TestClass]
    public class tstOrders
    {
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
            if (AnOrder.ExpectedReturnDate != Convert.ToDateTime("26/01/2018"))
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
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Stock_IDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method
            string Stock_ID = ""; //this should trigger an error message
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Stock_IDMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store am error message
            String Error = "";
            //create some test data to pass the method
            string Stock_ID = "567";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Stock_IDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "56789";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Stock_IDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678912";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Stock_IDMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "56789123";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Stock_IDMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "567891";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Stock_IDMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "56789123";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Stock_IDExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "";
            Stock_ID = Stock_ID.PadRight(100, '1');
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Order_DateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to string variable
            string Order_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Order_DateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to string variable
            string Order_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Order_DateMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to string variable
            string Order_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Order_DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to string variable
            string Order_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Order_DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to string variable
            string Order_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Order_DateInvalidData()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //set the order date to a non date value
            string Order_Date = "this is not a date";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Expected_Return_DateExtremeMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Order_Date = "12/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to string variable
            string Expected_Return_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Expected_Return_DateMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Order_Date = "12/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to string variable
            string Expected_Return_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Expected_Return_DateMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Order_Date = "12/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to string variable
            string Expected_Return_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Expected_Return_DateMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Order_Date = "12/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to string variable
            string Expected_Return_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void Expected_Return_DateExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Order_Date = "12/01/2018";
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //create a variable to store the test date data
            DateTime TestDate;
            //Set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to string variable
            string Expected_Return_Date = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Customer_IDMinLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Customer_IDMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Customer_IDMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "1234";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Customer_IDMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "1234567";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Customer_IDMid()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Payment_MethodMin()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Payment_MethodMax()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Card";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Payment_MethodMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //string variable to store any error messages
            String Error = "";
            //create some test data to pass to the method
            string Stock_ID = "5678";
            string Expected_Return_Date = "26/01/2018";
            string Order_Date = DateTime.Now.Date.ToString();
            string Customer_ID = "123456";
            string Payment_Method = "Cards";
            //invoke the method
            Error = AnOrder.Valid(Stock_ID, Expected_Return_Date, Order_Date, Customer_ID, Payment_Method);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

    }
} 
