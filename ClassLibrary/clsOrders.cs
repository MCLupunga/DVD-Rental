using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        //private data member for OrderNo
        private string mOrderNo;
        //private data member for CustomerID
        private string mCustomerID;
        //private data member for StockID
        private string mStockID;
        //private data member for ExpectedReturnDate
        private DateTime mExpectedReturnDate;
        //private data member for order date
        private DateTime mOrderDate;
        //private data member for PaymentMethod
        private string mPaymentMethod;

        //public property for OrderNo
        public string OrderNo
        {
            get
            {
                //return the private data
                return mOrderNo;
            }
            set
            {
                //set the value of the private data member
                mOrderNo = value;
            }
        }
        //public property for CustomerID
        public string CustomerID
        {
            get
            {
                //return the private data
                return mCustomerID;
            }
            set
            {
                //set the value of the private data member
                mCustomerID = value;
            }
        }
        //public property for StockID
        public string   StockID
        {
            get
            {
                //return the private data
                return mStockID;
            }
            set
            {
                //set the value of the private data member
                mStockID = value;
            }
        }
        //public property for ExpectedReturnDate
        public DateTime ExpectedReturnDate
        {
            get
            {
                //return the private data
                return mExpectedReturnDate;
            }
            set
            {
                //set the value of the private data member
                mExpectedReturnDate = value;
            }
        }
        //public property for OrderDate
        public DateTime OrderDate
        {
            get
            {
                //return the private data
                return mOrderDate;
            }
            set
            {
                //set the value of the private data member
                mOrderDate = value;
            }
        }
        //public property for PaymentMethod
        public string PaymentMethod
        {
            get
            {
                //return the private data
                return mPaymentMethod;
            }
            set
            {
                //set the value of the private data member
                mPaymentMethod = value;
            }
        }
        public bool Find(string OrderNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order number to search for
            DB.AddParameter("@OrderNo", OrderNo);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderNo");
            //if one record is found (there should be either 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderNo = Convert.ToString(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerID = Convert.ToString(DB.DataTable.Rows[0]["CustomerID"]);
                mStockID = Convert.ToString(DB.DataTable.Rows[0]["StockID"]);
                mExpectedReturnDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ExpectedReturnDate"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mPaymentMethod = Convert.ToString(DB.DataTable.Rows[0]["PaymentMthod"]);
                //return that everything worked ok
                return true;
            }
            //if no record is found
            else
            {
                //return false indicating a problem
                return false;
            }
        }
    }
}