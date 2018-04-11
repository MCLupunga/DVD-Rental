using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        //private data member for the CustomerNo property
        private Int32 mCustomerNo;
        private bool mActive;
        //private data member for the DateAdded property
        private DateTime mDateAdded;
        //private data member for the DOB property
        private DateTime mDOB;
        //private data member for the email property
        private string mEmail;
        //private data member for the FirstName property
        private string mFirstName;
        //private data member for the LastName property
        private string mLastName;
        //private data member for the MembershipCardNo property
        private Int32 mMembershipCardNo;
        //private data member for the PhoneNo
        private string mPhoneNo;

        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }
        //public property for DateAdded
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //public property for CustomerNO
        public int CustomerNo
        {
            get
            {
                //return the private data 
                return mCustomerNo;
            }
            set
            {
                //set the private data 
                mCustomerNo = value;
            }
        }

        //public property for DOB
        public DateTime DOB
        {
            get
            {
                //return the private data
                return mDOB;
            }
            set
            {
                //set the private data
                mDOB = value;
            }
        }

        //public property for Email
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the private data 
                mEmail = value;
            }
        }

        //public property for FirstName
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the private data 
                mFirstName = value;
            }
        }

        //public property for LastName
        public string LastName
        {
            get
            {
                //return the private data
                return mLastName;
            }
            set
            {
                //set the private data 
                mLastName = value;
            }
        }

        //public property for MembershipCardNo
        public int MembershipCardNo
        {
            get
            {
                //return the private data 
                return mMembershipCardNo;
            }
            set
            {
                //set the private data 
                mMembershipCardNo = value;
            }
        }

        //public property for PhoneNo
        public string PhoneNo
        {
            get
            {
                //return the private data
                return mPhoneNo;
            }
            set
            {
                //set the private data 
                mPhoneNo = value;
            }
        }


        public bool Find(int CustomerNo)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the customerno to the search
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomers_FilterByCustomerNo");
            //if one record is found (there should be either 1 or 0)
            if (DB.Count == 1)
            {
                //set the private data member to the test data value
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mMembershipCardNo = Convert.ToInt32(DB.DataTable.Rows[0]["MembershipCardNo"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["PhoneNo"]);
                mActive = true;
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

        public string Valid(string firstName, string lastName, string dateAdded, string dOB, string email, string phoneNo)
        {
            //create a string variable to store the error 
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the CustomerNo if blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The customer no may not be blank : ";
            }
            //if the customerno is greater than 7 characters
            if (firstName.Length > 50)
            {
                //record the error 
                Error = Error + "The customerNo must be less than 1 characters";
            }
            //copy the dateAdded value to the DateTemp variable
            DateTemp = Convert.ToDateTime(dateAdded);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be put in the past : ";
            }
            //check to see that the date is greater than today's date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the future : ";
            }
            //return any error messages
            return Error;
            {
                //create a string variable to store the error
                //String Error = "";
                //if the CustomerNo is blank
                if (firstName == "0")
                {
                    //record the error 
                    Error = Error + "The firstName may not be blank : ";
                }
                //if the FirstName is no greater than 51 characters
                if (firstName.Length > 51)
                {
                    //record the error 
                    Error = Error + "The firstName must be less than 51 characters : ";
                }
                //return any error messages 
                return Error;
            }
        }
    }
}