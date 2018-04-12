using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomersCollection
    {
        //private data member for the list
        List<clsCustomers> mCustomerList = new List<clsCustomers>();
        //public property for the customer list
        public List<clsCustomers> CustomersList
        {
            get
            {
                //return the private data
                return mCustomerList;
            }
            set
            {
                //set the private data
                mCustomerList = value;
            }
        }
        //public property for count
        public int Count
        {
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsCustomers ThisCustomers { get; set; }


        //constructor for the class
        public clsCustomersCollection()
        {
            //create the items of test data
            clsCustomers TestItem = new clsCustomers();
            //set its properties
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.DOB = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "johnsmith@email.co.uk";
            TestItem.PhoneNo = "07865432345";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the time to the test list
            mCustomerList.Add(TestItem);
            //reinstialise the object for some new data
            TestItem = new clsCustomers();
            //set its properites
            TestItem.CustomerNo = 10;
            TestItem.FirstName = "Sarah";
            TestItem.LastName = "Green";
            TestItem.DOB = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "sfgreenh@email.co.uk";
            TestItem.PhoneNo = "07867322345";
            TestItem.DateAdded = DateTime.Now.Date;
            //add the item to the test list
            mCustomerList.Add(TestItem);
        }
    }

    /////The following code does not work when I tried to put it in
    //{
    //var for the index
    //Int32 Index = 0;
    //var to store the record count
    //Int32 RecordCount = 0;
    //object for data connection
    //clsDataConnection DB = new clsDataConnection();
    //execute the stored procedure
    //DB.Execute("sproc_tblCustomers_SelectAll");
    //get the count of records
    //RecordCount = DB.Count;
    //while there are records to proccess
    //while (Index < RecordCount)
    //{
    //create a blank customers
    //clsCustomers ACustomers = new clsCustomers();
    //read in the fields for the current record
    //ACustomers.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
    //ACustomers.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
    //ACustomers.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
    //ACustomers.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
    //ACustomers.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
    //ACustomers.LastName= Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
    //ACustomers.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["PhoneNo"]);
    //add the record to the private data member
    //mCustomerList.Add(ACustomers);
    //point at the next record
    //Index++;
    //}
}
