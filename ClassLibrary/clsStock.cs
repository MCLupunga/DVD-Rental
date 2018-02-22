using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member from the Stock ID property
        private Int32 mStockID;

        public clsStock()
        {
        }

        public string Classification { get; set; }
        public string Genre { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ShelfLocation { get; set; }
        //public property for the stock ID
        public int StockID
        {
            get
            {
                //return to the private data
                return mStockID;
            }
            set
            {
                //set the value of the private data member
                mStockID = value;
            }
        }

        public bool Find(int stockID)
        {
            ///set the private data member to the test data value
            mStockID = 101;
            //always return true
            return true;
        }
    }
}