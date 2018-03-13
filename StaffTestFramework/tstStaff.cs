using System;
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
            if (AStaff.FirstName != "Maggie")
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
            Boolean Ok = true;
            //create some test data to use with the method
            String StaffCode = "MDZ123";
            //invoke test method
            Found = AStaff.Find(StaffCode);
            //check the property
            if (AStaff.LastName ! = "Dzikiti")
                
        }
    }    
}
