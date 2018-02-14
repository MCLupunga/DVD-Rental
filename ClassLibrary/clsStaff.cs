using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NextOfKin { get; set; }
        public string PhoneNo { get; set; }
        public string StaffCode { get; set; }

        public bool Find(string staffCode)
        {
            //always return true
            return true;
        }
    }
}