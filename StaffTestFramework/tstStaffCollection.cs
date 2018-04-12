using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace StaffTestFramework
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to seethat it exists
            Assert.IsNotNull(AllStaff);
        }
        [TestMethod]
        public void StaffListOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Address = "1 Dmu St  ";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.FirstName = "Mary";
            TestItem.LastName = "Zugs";
            TestItem.NextOfKin = "Dave Zugs";
            TestItem.PhoneNo = "781234562";
            TestItem.StaffCode = "MDZ123";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        
        
        [TestMethod]
        public void ThisStaffPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set the properties of the test object
            TestStaff.Address = "1 Dmu St  ";
            TestStaff.DateOfBirth = DateTime.Now.Date;
            TestStaff.FirstName = "Mary";
            TestStaff.LastName = "Zugs";
            TestStaff.NextOfKin = "Dave Zugs";
            TestStaff.PhoneNo = "781234562";
            TestStaff.StaffCode = "MDZ123";
            //assign the data to the property
            AllStaff.ThisStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }
        [TestMethod]
        public void ListAndCountOk()
        {
            //create an instance of the class we want to create
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add an item to the list
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //set its properties
            TestItem.Address = "1 Dmu St  ";
            TestItem.DateOfBirth = DateTime.Now.Date;
            TestItem.FirstName = "Mary";
            TestItem.LastName = "Zugs";
            TestItem.NextOfKin = "Dave Zugs";
            TestItem.PhoneNo = "781234562";
            TestItem.StaffCode = "MDZ123";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }
  
       
        
    }
}
