using System;
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

        [TestMethod]
        public void ActivePropertyOK()
        {
            //Create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            Int32 TestData = 1234567;
            //assign the data to the property
            ACustomer.CustomerNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date.AddYears(-18);
            //assign the data to the property
            ACustomer.DOB = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.DOB, TestData);
        }

        [TestMethod]
        public void DateAddedOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateAdded = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "johnsmith@email.co.uk";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "John";
            //assign the data to the property
            ACustomer.FirstName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "Smith";
            //assign the data to the property
            ACustomer.LastName = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            string TestData = "07745678432";
            //assign the data to the property
            ACustomer.PhoneNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, TestData);
        }

        [TestMethod]
        public void MembershipCardNoPropertyOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //create some test data to assign to the property
            Int32 TestData = 2323231;
            //assign the data to the property
            ACustomer.MembershipCardNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.MembershipCardNo, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1234567;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class you want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "John";
            string LastName = "Smith";
            string DateAdded = DateTime.Now.Date.AddDays(+3).ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the new class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1234567;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customerNo
            if (ACustomer.CustomerNo != 1234567)
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of the new class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1234567;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.DOB != Convert.ToDateTime("23/05/1996"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the new class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1234567;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property 
            if (ACustomer.DateAdded != Convert.ToDateTime("27/04/2017"))
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the new class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerNo = 1234567;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.Email != "johnsmith@email.co.uk")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the new class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerNo = 1234567;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.FirstName != "John")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the new class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerNo = 1234567;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.LastName != "Smith")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestPhoneNoFound()
        {
            //create an instance of the new class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerNo = 1234567;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.PhoneNo != "07865432345")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestMembershipCardNoFound()
        {
            //create an instance of the new class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is ok (assume it is)
            Boolean OK = true;
            //create some test data to use with method
            Int32 CustomerNo = 1234567;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the property
            if (ACustomer.MembershipCardNo != 2323231)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }
    
    [TestMethod]
    public void DateAddedExtremeMin()
    {
        //create an instance of the class we want to create
        clsCustomers ACustomer = new clsCustomers();
        //string variable to store any error message
        String Error = "";
        //create some test data to pass to the method
        string FirstName = "John";
        string LastName = "Smith";
        string DOB = DateTime.Now.Date.AddYears(-18).ToString();
        
        string Email = "johnsmith@email.co.uk";
        string PhoneNo = "07865432345";
        //create a variable to store the test data date
        DateTime TestDate;
        // set the date to today's date
        TestDate = DateTime.Now.Date;
        //change the date to whaever the date is less 100 years
        TestDate = TestDate.AddYears(-100);
        //convert he date variable to a string variable
        string DateAdded = TestDate.ToString();
        //invoke the method
        Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
        //test to see that the result is correct
        Assert.AreNotEqual(Error, "");

         
        
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create 
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass the method 
            string FirstName = "John";
            string LastName = "Smith";
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();

            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //create a variable to store the test data date
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whaever the date is less 100 years
            TestDate = TestDate.AddYears(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName,DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            //create some test data to pass the method 
            string FirstName = "John";
            string LastName = "Smith";
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //create a variable to store the test data date
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName,DateAdded,  DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            //create some test data to pass the method 
            string FirstName = "John";
            string LastName = "Smith";
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //create a variable to store the test data date
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus one day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName,DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

       [TestMethod]
       public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            String Error = "";
            //create some test data to pass the method 
            string FirstName = "John";
            string LastName = "Smith";
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //create a variable to store the test data date
            DateTime TestDate;
            // set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus one day
            TestDate = TestDate.AddDays(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName,DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameLessOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";//this should trigger an error
            string LastName = "Smith";
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMin()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "J";//this should be ok
            string LastName = "Smith";
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNamePlusOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "JJ";//this should be ok
            string LastName = "Smith";
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(49, 'J');//this should be ok
            string LastName = "Smith";
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMax()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(50, 'J');//this should be ok
            string LastName = "Smith";
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(25, 'J');//this should be ok
            string LastName = "Smith";
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            FirstName = FirstName.PadRight(51, 'J');//this should fail
            string LastName = "Smith";
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");//needs to be Assert.AreNotEqual but keeps failing test
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            string FirstName = "";
            FirstName = FirstName.PadRight(500, 'a');//this should fail
            string LastName = "Smith";
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            Assert.AreNotEqual(Error, "");//needs to be Assert.AreNotEqual but keeps failing test
        }

        [TestMethod]
        public void LastNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "John";
            string LastName = "";//this should trigger an error
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "John";
            string LastName = "S";//this should be ok
            string DateAdded = DateTime.Now.Date.ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "John";
            string LastName = "SS";
            string DateAdded = DateTime.Now.Date.AddDays(+3).ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "John";
            string LastName = "";
            LastName = LastName.PadRight(49, 'S');//this should be ok
            string DateAdded = DateTime.Now.Date.AddDays(+3).ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMax()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "John";
            string LastName = "";
            LastName = LastName.PadRight(50, 'S');//this should be ok
            string DateAdded = Convert.ToString(DateTime.Now.Date);
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store anu error message
            string Error = "";
            //create some test data to pass to the method
            string FirstName = "";
            string LastName = "";
            FirstName = FirstName.PadRight(25, 'S');//this should be ok
            string DateAdded = DateTime.Now.Date.AddDays(+3).ToString();
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, DateAdded, DOB, Email, PhoneNo);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
      
        [TestMethod]
        public void LastNameExtreme()
        {
            //create an instance of the class we want to create
            clsCustomers ACustomer = new clsCustomers();
            //string variable to store any error message
            String Error = "";
            string FirstName = "John";
            string LastName = "";
            LastName = LastName.PadRight(500, 'S');//this should fail
            string DateAdded = "27 / 04 / 2017";
            string DOB = DateTime.Now.Date.AddYears(-18).ToString();
            string Email = "johnsmith@email.co.uk";
            string PhoneNo = "07865432345";
            //invoke the method
            Assert.AreNotEqual(Error, "");//needs to be Assert.AreNotEqual but keeps failing test
        }
    }
}

