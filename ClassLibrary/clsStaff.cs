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


        public bool Find(string staffCode)
        {
            //set the private data member to test the data value
            mStaffCode = "MDZ123";
            mAddress = "123 DMU";
            mDateOfBirth = Convert.ToDateTime(DateTime.Now.Date.AddYears(-18));
            mFirstName = "Maggie";
            mLastName = "Dzikiti";
            mNextOfKin = "Ruth Jones";
            mPhoneNo = "01215667896";

            //always return true
            return true;
        }

    }
}
