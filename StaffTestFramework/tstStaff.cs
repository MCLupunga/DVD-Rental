﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace StaffTestFramework
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance
            clsStaff AStaff = new clsStaff();
            //test to see that the class exists
            Assert.IsNotNull(AStaff);
        }
        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "123 DMU";
            //assign the data to the property
            AStaff.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Address, TestData);
        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Maggie";
            //assign the data to the property
            AStaff.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Dzikiti";
            //assign the data to the property
            AStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.LastName, TestData);
        }
        [TestMethod]
        public void NextOfKinPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Ruth Jones";
            //assign the data to the property
            AStaff.NextOfKin = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.NextOfKin, TestData);
        }
        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "01215667896";
            //assign the data to the property
            AStaff.PhoneNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.PhoneNo, TestData);
        }
        [TestMethod]
        public void StaffCodePropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "MDZ123";
            //assign the data to the property
            AStaff.StaffCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.StaffCode, TestData);
        }
        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date.AddYears(-18);
            //assign the data to the property
            AStaff.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.DateOfBirth, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string StaffCode = "MDZ123";
            //invoke the method
            Found = AStaff.Find(StaffCode);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffCodeFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (aasume it is)
            Boolean Ok = true;
            //create some test data to use with the method
            String StaffCode = "MDZ123";
            //invoke test method
            Found = AStaff.Find(StaffCode);
            //check the staff code
            if (AStaff.StaffCode != "MDZ123")
            {
                Ok = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void TestFirstNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (aasume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String StaffCode = "MDZ123";
            //invoke test method
            Found = AStaff.Find(StaffCode);
            //check the staff code
            if (AStaff.FirstName != "Mary")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestLastNameFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (aasume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String StaffCode = "MDZ123";
            //invoke test method
            Found = AStaff.Find(StaffCode);
            //check the property
            if (AStaff.LastName != "Zugs")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
                
        }
        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (aasume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String StaffCode = "MDZ123";
            //invoke test method
            Found = AStaff.Find(StaffCode);
            //check the property
            if (AStaff.Address != "1 Dmu St  ")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfBirthFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (aasume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String StaffCode = "MDZ123";
            //invoke test method
            Found = AStaff.Find(StaffCode);
            //check the property
            if (AStaff.DateOfBirth !=Convert.ToDateTime("01 / 01 / 1992"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestNextofKinFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (aasume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String StaffCode = "MDZ123";
            //invoke test method
            Found = AStaff.Find(StaffCode);
            //check the property
            if (AStaff.NextOfKin != "Dave Zugs")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneNumberFound()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (aasume it is)
            Boolean OK = true;
            //create some test data to use with the method
            String StaffCode = "MDZ123";
            //invoke test method
            Found = AStaff.Find(StaffCode);
            //check the property
            if (AStaff.PhoneNo != "781234562")
            {
                OK = false;
            }
            //test to see that the rsult is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu St  ";
            string DOB = DateTime.Now.Date.ToString();
            string First_name = "Mary";
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void First_nameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu St";
            string DOB = "01/01/1992";
            string First_name = ""; //trigger error
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void First_nameMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu St  ";
            string DOB = DateTime.Now.Date.ToString();
            string First_name = "a";//this should be ok
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void First_nameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu St  ";
            string DOB = DateTime.Now.Date.ToString();
            string First_name = "aa";//this should be ok
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void First_nameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu St  ";
            string DOB = DateTime.Now.Date.ToString();
            string First_name = "";
            First_name = First_name.PadRight(49, 'a');//this should be ok
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void First_nameMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu St  ";
            string DOB = DateTime.Now.Date.ToString();
            string First_name = "";
            First_name = First_name.PadRight(50, 'a');//this should be ok
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void First_nameMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu St  ";
            string DOB = DateTime.Now.Date.ToString();
            string First_name = "";
            First_name = First_name.PadRight(25, 'a');//this should be ok
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu st ";
            string First_name = "Mary";
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date of birth is less 14 years
            TestDate = TestDate.AddYears(-14);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu st ";
            string First_name = "Mary";
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date of birth is less 15 years 364 days
            TestDate = TestDate.AddYears(-15).AddDays(-364);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu st ";
            string First_name = "Mary";
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu st ";
            string First_name = "Mary";
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu st ";
            string First_name = "Mary";
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu st ";
            string First_name = "Mary";
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMid()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu st ";
            string First_name = "Mary";
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            //create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //string variable to store any error message
            string Error = "";
            //create some test data to pass to the method
            string Address = "1 Dmu st ";
            string First_name = "Mary";
            string Last_name = "Zugs";
            string Next_of_Kin = "Dave Zugs";
            string Phone_Number = "781234562";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date of birth is less 14 years
            TestDate = TestDate.AddYears(70);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Address, DOB, First_name, Last_name, Next_of_Kin, Phone_Number);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

    }   
     
}
