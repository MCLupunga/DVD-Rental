using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        //private data member for th elist
        List<clsStock> mStockList = new List<clsStock>();
        //public property for the stock list
        public List<clsStock> StockList
        {
            get
            {
                //return the private data 
                return mStockList;
            }
            set
            {
                //set the private data
                mStockList = value;
            }
        }
        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStockList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsStock ThisStock { get; set; }

        //constructor for the class
        public clsStockCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //executre stored prcedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank stock
                clsStock AStock = new clsStock();
                AStock.StockID = Convert.ToString(DB.DataTable.Rows[Index]["StockID"]);
                AStock.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]); ;
                AStock.Genre = Convert.ToString(DB.DataTable.Rows[Index]["Name"]); ;
                AStock.Classification = Convert.ToString(DB.DataTable.Rows[Index]["Name"]); ;
                AStock.ReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["ReleaseDate"]);
                AStock.ShelfLocation = Convert.ToInt32(DB.DataTable.Rows[Index]["ShelfLocation"]); 
                AStock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]); ;
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //poiont at the next record
                Index++;
            }
        }
    }
}