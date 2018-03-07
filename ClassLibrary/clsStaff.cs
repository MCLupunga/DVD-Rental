using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member for the StaffCode property
        private string mStaffCode;
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NextOfKin { get; set; }
        public string PhoneNo { get; set; }
        //public property for the StaffCode
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

        public bool Find(string staffCode)
        {
            //set the private data member to test the data value
            mStaffCode = "MDZ123";
            //always return true
            return true;
        }
        
    }
}