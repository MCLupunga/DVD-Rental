using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace StockTestFramework
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStock);
        }

        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockID = "404";
            TestItem.Name = "White Chicks";
            TestItem.Genre = "Comedy";
            TestItem.Classification = "15";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.ShelfLocation = 6;
            TestItem.Price = 2;
            TestItem.Quantity = 7;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //assign the data to the property
            AllStock.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set properties of the test object
            TestStock.StockID = "404";
            TestStock.Name = "White Chicks";
            TestStock.Genre = "COmedy";
            TestStock.Classification = "15";
            TestStock.ReleaseDate = DateTime.Now.Date;
            TestStock.ShelfLocation = 6;
            TestStock.Price = 2;
            TestStock.Quantity = 7;
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see the two values are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            //create an instnace of the class we want to create
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the propert
            //in this case the data needs to be a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.StockID = "404";
            TestItem.Name = "White Chicks";
            TestItem.Genre = "Comedy";
            TestItem.Classification = "15";
            TestItem.ReleaseDate = DateTime.Now.Date;
            TestItem.ShelfLocation = 6;
            TestItem.Price = 2;
            TestItem.Quantity = 7;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, TestList.Count);
        }
    }
}
