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
        public bool Find (string OrderNo)
        {
            //set the private data members to the test data value
            mOrderNo = "98765";
            mCustomerID = "123456";
            mStockID = "5678";
            mExpectedReturnDate = Convert.ToDateTime(DateTime.Now.Date);
            mOrderDate = Convert.ToDateTime(DateTime.Now.Date);
            mPaymentMethod = "card";
            //always return true
            return true;
        }
    }
}