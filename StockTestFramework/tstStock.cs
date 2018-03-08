﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace StockTestFramework
{
    [TestClass]
    public class tstStockk
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //test to see if it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void StockIDPropertyOK()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.StockID = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.StockID, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            String TestData = "Die Hard";
            //assign the data to the property
            AStock.Name = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.Name, TestData);
        }

        [TestMethod]
        public void GenrePropertyOK()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Action";
            //assign the data to the property
            AStock.Genre = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.Genre, TestData);
        }

        [TestMethod]
        public void ClassificationPropertyOK()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "12A";
            //assign the data to the property
            AStock.Classification = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.Classification, TestData);
        }

        [TestMethod]
        public void ShelfLocationPropertyOK()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 23;
            //assign the data to the property
            AStock.ShelfLocation = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.ShelfLocation, TestData);
        }

        [TestMethod]
        public void ReleaseDateProperty()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.ReleaseDate = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.ReleaseDate, TestData);
        }

        [TestMethod]
        public void QuantityProperty()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 10;
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        [TestMethod]
        public void PriceProperty()
        {
            //create an instance of the class
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockID = 1;
            //invoke the method
            Found = AStock.Find(StockID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIDFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean varibale to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 101;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the stock ID
            if (AStock.StockID != 101)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of teh class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 101;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Name != "The Hunger Games")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestGenreFound()
        {
            //create an instance of teh class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 101;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Genre != "Drama")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestClassificationFound()
        {
            //create an instance of teh class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 101;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Classification != "12A")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShelfLocationFound()
        {
            //create an instance of teh class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 101;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.ShelfLocation != 23)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestReleaseDateFound()
        {
            //create an instance of teh class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 101;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.ReleaseDate !=Convert.ToDateTime(DateTime.Now.Date))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of teh class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 101;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Quantity != 10)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of teh class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the search
            Boolean Found = false;
            //boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockID = 101;
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.Price != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
