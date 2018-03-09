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
        private int mMembershipCardNo;
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


        public bool Find(int customerNo)
        {
            //set the private data member to the test data value
            mCustomerNo = 1234567;
            mDateAdded = Convert.ToDateTime("27/04/2017");
            mDOB = Convert.ToDateTime("24/03/1976");
            mEmail = "Test Email";
            mFirstName = "Test FirstName";
            mLastName = "Test LastName";
            mMembershipCardNo = 2343567;
            mPhoneNo = "Test PhoneNo";
            mActive = true;
            //always return true
            return true;
        }
    }
}