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
        private string mPaymentMethod;]

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
    }
    
}