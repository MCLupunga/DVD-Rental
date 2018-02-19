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
            Int32 TestData = 1;
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
            string TestData = "scarlet@gmail.com";
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
            string TestData = "Scarlet";
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
            string TestData = "Kidd";
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
            Int32 TestData = 1;
            //assign the data to the property
            ACustomer.MembershipCardNo = TestData;
            //test to see if the two values are the same
            Assert.AreEqual(ACustomer.MembershipCardNo, TestData);
        }
    }
}
