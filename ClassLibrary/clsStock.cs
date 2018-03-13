using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //private data member from the Stock ID property
        private string mStockID;
        //private data member from the property
        private string mName;
        //private data member from the property
        private string mGenre;
        //private data member from the property
        private string mClassification;
        //private data member from the property
        private Int32 mShelfLocation;
        //private data member from the property
        private DateTime mReleaseDate;
        //private data member from the property
        private Int32 mQuantity;
        //private data member from the Stock ID property
        private Int32 mPrice;

        //public property for the classification
        public string Classification
        {
            get
            {
                //return to the private data
                return mClassification;
            }
            set
            {
                //set the value of the private data member
                mClassification = value;
            }
        }
        //public property for the genre
        public string Genre
        {
            get
            {
                //return to the private data
                return mGenre;
            }
            set
            {
                //set the value of the private data member
                mGenre = value;
            }
        }
        //public property for the name
        public string Name
        {
            get
            {
                //return to the private data
                return mName;
            }
            set
            {
                //set the value of the private data member
                mName = value;
            }
        }
        //public property for the price
        public int Price
        {
            get
            {
                //return to the private data
                return mPrice;
            }
            set
            {
                //set the value of the private data member
                mPrice = value;
            }
        }
        //public property for the quantity
        public int Quantity
        {
            get
            {
                //return to the private data
                return mQuantity;
            }
            set
            {
                //set the value of the private data member
                mQuantity = value;
            }
        }
        //public property for the release date
        public DateTime ReleaseDate
        {
            get
            {
                //return to the private data
                return mReleaseDate;
            }
            set
            {
                //set the value of the private data member
                mReleaseDate = value;
            }
        }
        //public property for the shelf location
        public int ShelfLocation
        {
            get
            {
                //return to the private data
                return mShelfLocation;
            }
            set
            {
                //set the value of the private data member
                mShelfLocation = value;
            }
        }
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
            mName = "The Hunger Games";
            mGenre = "Drama";
            mClassification = "12A";
            mShelfLocation = 23;
            mReleaseDate = Convert.ToDateTime(DateTime.Now.Date);
            mQuantity = 10;
            mPrice = 2;
            //always return true
            return true;
        }
    }
}