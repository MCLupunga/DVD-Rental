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
        public string StockID
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

        public bool Find(string StockID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customerno to the search
            DB.AddParameter("@StockID", StockID);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockID");
            //if one record is found (there should be either 1 or 0)
            if (DB.Count == 1)
            {
                //set the private data member to the test data value
                mStockID = Convert.ToString(DB.DataTable.Rows[0]["StockID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mGenre = Convert.ToString(DB.DataTable.Rows[0]["Genre"]);
                mClassification = Convert.ToString(DB.DataTable.Rows[0]["Classification"]);
                mShelfLocation = Convert.ToInt32(DB.DataTable.Rows[0]["ShelfLocation"]);
                mReleaseDate = Convert.ToDateTime(DB.DataTable.Rows[0]["ReleaseDate"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToInt32(DB.DataTable.Rows[0]["Price"]);
                //always return true
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string stockID, string name, string genre, string classification, string releaseDate)
        {
            //create a string variable to store the error
            string Error = "";
            //if the HouseNo is blank
            if (stockID.Length == 0)
            {
                //record the error
                Error = Error + "The Stock ID may not be blank : ";
            }
            //if the StockID is greater than 8 characters
            if (stockID.Length > 8)
            {
                //record the error
                Error = Error + "The Stock ID must be less than 8 characters : ";
            }
            //return any error messages
            return Error;
        }
    }
}