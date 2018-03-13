using System;

namespace ClassLibrary
{
    public class clsOrders
    {
        public string CustomerID { get; set; }
        public string StockID { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNo { get; set; }
        public string PaymentMethod { get; set; }

        public bool Find(string orderNo)
        {
            //always return true
            return true;
        }
    }
    
}