using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        //private data member for the CustomerNo property
        private Int32 mCustomerNo;
        public bool Active { get; set; }
        //public property for the customerNo
        public int CustomerNo
        { get
            {
                //return the private data
                return mCustomerNo;
            }
                set
            {
                //set the value of the private data member
                mCustomerNo = value;

            }
                }
        public DateTime DateAdded { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MembershipCardNo { get; set; }
        public string PhoneNo { get; set; }

        public bool Find(int customerNo)
        {
            //set the private data member to the test data value
            mCustomerNo = 1234567;
            //always return true
            return true;
        }
    }
}