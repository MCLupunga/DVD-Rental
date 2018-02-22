using System;
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
            Int32 TestData = 1234;
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
            if (AStock.Name != "Test Name")
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
            if (AStock.Genre != "Test Genre")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
