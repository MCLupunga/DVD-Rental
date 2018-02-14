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
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exsists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            Int32 TestData = 1;
            //asssign the data to the property
            ACustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.CustomerNo, TestData);

        }
        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "scarlet";
            //Assign the data to the property
            ACustomer.FirstName = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Kidd";
            //Assign the data to the property
            ACustomer.LastName = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(ACustomer.LastName, TestData);

        }
        [TestMethod]
        public void EmailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Create some test data to assign to the property
            string TestData = "scarletx@hotmail.co.uk";
            //Assign the data to the property
            ACustomer.Email = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void PhoneNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "07903538425";
            //Assign the data to the property
            ACustomer.PhoneNo = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.PhoneNo, TestData);

        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //Assign the data to the property
            ACustomer.Active = TestData;
            //test if the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }
        [TestMethod]
        public void MembershipCardNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "1234567";
            //assign the test data to the property
            ACustomer.MembershipCardNo = TestData;
            //Test to see if the two values are the same
            Assert.AreEqual(ACustomer.MembershipCardNo, TestData);            
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //Assign the data to the property
            ACustomer.DateAdded = TestData;
            //Test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateAdded, TestData);
        }
            [TestMethod]
            public void DateOfBirthPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date.AddYears(-18);
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //Create some test data to assign with the method
            Int32 CustomerNo = 1;
            //invoke the method 
            Found = ACustomer.Find(CustomerNo);
            //test to see if the result is correct
            Assert.IsTrue(Found);
        }
    }
        
    }

