﻿using System;

namespace ClassLibrary
{
    public class clsCustomers
    {
        public bool Active { get; set; }
        public int CustomerNo { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MembershipCardNo { get; set; }
        public string PhoneNo { get; set; }

        public bool Find(int customerNo)
        {
            //always return true
            return true;
        }
    }
}