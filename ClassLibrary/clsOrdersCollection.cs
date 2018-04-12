using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        //private data member for the list
        List<clsOrders> mOrderList = new List<clsOrders>();
        //public property for the order list
        public List<clsOrders> OrderList
        {
            get
            {
                //return the private data
                return mOrderList;
            }
            set
            {
                //set the private data
                mOrderList = value;
            }
        }
        //public property for the order list
        public int Count
        {
            get
            {
                //return the count of the list
                return mOrderList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        //constructor for the class
        public clsOrdersCollection()
        {
            //create the items of test data
            clsOrders TestItem = new clsOrders();
            //set its properties
            TestItem.CustomerID = "123456";
            TestItem.StockID = "5678";
            TestItem.OrderNo = "98765";
            TestItem.PaymentMethod = "Card";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ExpectedReturnDate = DateTime.Now.Date.AddDays(7);
            //add the item to the test list
            mOrderList.Add(TestItem);
            //re initialise the object for some new data
            TestItem = new clsOrders();
            //set its properties
            TestItem.CustomerID = "234567";
            TestItem.StockID = "1234";
            TestItem.OrderNo = "87654";
            TestItem.PaymentMethod = "Card";
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.ExpectedReturnDate = DateTime.Now.Date.AddDays(7);
            //add the item to the test list
            mOrderList.Add(TestItem);
        }

        ///The following code does not work when inserted
        //{
        //var for the index
        //Int32 Index = 0;
        //var to store the record count
        //Int32 RecordCount = 0;
        //object for data connection
        //clsDataConnection DB = new clsDataConnection();
        //execute the stored procedure
        //DB.Execute("sproc_tblOrders_SelectAll");
        //get the count of the records
        //RecordCount = DB.Count;
        //while there are records to be processed
        //while (Index < RecordCount)
        //{
        //create a blank order
        //clsOrders AnOrder = new clsOrders();
        //read in the fields from the current record
        //AnOrder.CustomerID = Convert.ToString(DB.DataTable.Rows[Index]["customerID"]);
        //AnOrder.StockID = Convert.ToString(DB.DataTable.Rows[Index]["StockID"]);
        //AnOrder.OrderNo = Convert.ToString(DB.DataTable.Rows[Index]["OrderNo"]);
        //AnOrder.PaymentMethod = Convert.ToString(DB.DataTable.Rows[Index]["PaymentMethod"]);
        //AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["OrderNo"]);
        //AnOrder.ExpectedReturnDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ExpectedReturnDate"]);
        //add the record to the private data member
        //mOrderList.Add(AnOrder);
        //point to the next record
        //Index++;
        //}
  

        ///the following code would not work on my part of the system


        public clsOrders ThisOrder { get; set; }
    }
}
