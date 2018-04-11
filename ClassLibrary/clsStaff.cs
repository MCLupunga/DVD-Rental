using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the StaffCode property
        private string mStaffCode;
        //private data member for the property
        public string mAddress;
        //private data member for the property
        public DateTime mDateOfBirth;
        //private data member for the property
        public string mFirstName;
        //private data member for the property
        public string mLastName;
        //private data member for the property
        public string mNextOfKin;
        //private data member for the property
        public string mPhoneNo;
        //private data member for the property


        //public property for staffcode
        public string StaffCode
        {
            get
            {
                //return the private data
                return mStaffCode;
            }
            set
            {
                //set the value of the private data
                mStaffCode = value;
            }
        }

        //public property for first name
        public string FirstName
        {
            get
            {
                //return the private data
                return mFirstName;
            }
            set
            {
                //set the value of the private data
                mFirstName = value;
            }
        }

        //public property for address
        public string Address
        {
            get
            {
                //return the private data
                return mAddress;
            }
            set
            {
                //set the value of the private data
                mAddress = value;
            }
        }

        //public property for DateOfBirth
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateOfBirth;
            }
            set
            {
                //set the value of the private data
                mDateOfBirth = value;
            }
        }
        //public property for NextOfKin
        public string NextOfKin
        {
            get
            {
                //return the private data
                return mNextOfKin;
            }
            set
            {
                //set the value of the private data
                mNextOfKin = value;
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
                //set the value of the private data
                mLastName = value;
            }
        }
        //public property for Phone Number
        public string PhoneNo
        {
            get
            {
                //return the private data
                return mPhoneNo;
            }
            set
            {
                //set the value of the private data
                mPhoneNo = value;
            }
        }
        public bool Find(string StaffCode)
        {
            //create an instance of the date connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staffcode to search for
            DB.AddParameter("@Staff_code", StaffCode);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByUserNo");
            //if one record is found (there should be either 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffCode = Convert.ToString(DB.DataTable.Rows[0]["Staff_Code"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["First_name"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["Last_name"]);
                mNextOfKin = Convert.ToString(DB.DataTable.Rows[0]["Next_of_Kin"]);
                mPhoneNo = Convert.ToString(DB.DataTable.Rows[0]["Phone_Number"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }
        }

        public string Valid(string address, string dOB, string first_name, string last_name, string next_of_Kin, string phone_Number)
        {
            //create a string variable to store the error
            string Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;
            //if the firstname is blank
            if (first_name.Length == 0)
            {
                //record the error
                Error = Error + "The first name may not be blank : ";
            }
            //if the first name is greater than 50 characters
            if (first_name.Length > 50)
            {
                //record the error
                Error = Error + "The first name must be less than 50 characters : ";
            }
            //cop the DOB value to the DateTemp variable
            DateTemp = Convert.ToDateTime(dOB);
            if (DateTemp < DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date cannot be in the past : ";
            }
            //check to see if the date is greater than todays date
            if (DateTemp > DateTime.Now.Date)
            {
                //record the error
                Error = Error + "The date can not be in the future : ";
            }
            //return any error message
            return Error;
        }
    }
}
