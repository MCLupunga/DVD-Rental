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
            string TestData = "125";
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
            string StockID = "125";
            //invoke the method
            Found = AStock.Find(StockID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = DateTime.Now.Date.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

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
            string StockID = "125";
            //invoke the method
            Found = AStock.Find(StockID);
            //check the stock ID
            if (AStock.StockID != "125")
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
            string StockID = "125";
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
            string StockID = "125";
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
            string StockID = "125";
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
            string StockID = "125";
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.ShelfLocation != 34)
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
            string StockID = "125";
            //invoke the method
            Found = AStock.Find(StockID);
            //check the property
            if (AStock.ReleaseDate != Convert.ToDateTime("04/03/2012"))
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
            string StockID = "125";
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
            string StockID = "125";
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

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = DateTime.Now.Date.ToString(); ;
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "T";
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = DateTime.Now.Date.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "Th";
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = DateTime.Now.Date.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(49, 'a');
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = DateTime.Now.Date.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(50, 'a');
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = DateTime.Now.Date.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(51, 'a');
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = DateTime.Now.Date.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(100, 'a');
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = DateTime.Now.Date.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(25, 'a');
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = DateTime.Now.Date.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMin()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "12A";
            //crate  variable to store the test data
            DateTime TestDate;
            //set the date to todys date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is is less than 30 years
            TestDate = TestDate.AddYears(-30);
            //convert the date vaiabe to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test ti see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinLessOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "12A";
            //crate  variable to store the test data
            DateTime TestDate;
            //set the date to todys date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMin()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "12A";
            //crate  variable to store the test data
            DateTime TestDate;
            //set the date to todys date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateMinPlusOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "12A";
            //crate  variable to store the test data
            DateTime TestDate;
            //set the date to todys date
            TestDate = DateTime.Now.Date;
            //change the date to whatever te date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateExtremeMax()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "12A";
            //crate  variable to store the test data
            DateTime TestDate;
            //set the date to todys date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 50 days
            TestDate = TestDate.AddDays(50);
            //convet the date variabe to a string variable
            string ReleaseDate = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ReleaseDateInvalidData()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "12A";
            //set the ReleaseDate to a non date value
            string ReleaseDate = "this is not a date";
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreMinLessOne()
        {
            //create a instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "";
            string Classification = "12A";
            string ReleaseDate = "04/03/2012";
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreMin()
        {
            //create a instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "D";
            string Classification = "12A";
            string ReleaseDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMinPlusOne()
        {
            //create a instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Dr";
            string Classification = "12A";
            string ReleaseDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxLessOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "";
            Genre = Genre.PadRight(49, 'a');
            string Classification = "12A";
            string ReleaseDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMax()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "";
            Genre = Genre.PadRight(50, 'a');
            string Classification = "12A";
            string ReleaseDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GenreMaxPlusOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "";
            Genre = Genre.PadRight(51, 'a');
            string Classification = "12A";
            string ReleaseDate = "04/03/2012";
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GenreExtremeMax()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "";
            Genre = Genre.PadRight(100, 'a');
            string Classification = "12A";
            string ReleaseDate = "04/03/2012";
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClassificationMinLessOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "";
            string ReleaseDate = "04/03/2012";
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClassificationMin()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "1";
            string ReleaseDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ClassificationMinPlusOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "12";
            string ReleaseDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ClassificationMaxLessOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "aaaaa";
            string ReleaseDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClassificationMax()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "aaaaaa";
            string ReleaseDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClassificationMaxPlusOne()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "aaaaaaa";
            string ReleaseDate = "04/03/2012";
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClassificationMid()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "12A";
            string ReleaseDate = Convert.ToString(DateTime.Now.Date);
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClassificationExtremeMax()
        {
            //create an instance of the class you want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Name = "The Hunger Games";
            string Genre = "Drama";
            string Classification = "";
            Classification = Classification.PadRight(10, 'a');
            string ReleaseDate = "04/03/2012";
            //invoke the method
            Error = AStock.Valid(Name, Genre, Classification, ReleaseDate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }
}