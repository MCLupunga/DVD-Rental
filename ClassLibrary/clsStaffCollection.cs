using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        //public property for the count
        public int Count
        {
            get
            {
                //return the count of the list
                return mStaffList.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsStaff AStaff = new clsStaff();
                //read in the field from the current record
                AStaff.StaffCode = Convert.ToString(DB.DataTable.Rows[Index]["Staff_Code"]);
                AStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AStaff.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["First_name"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["Last_name"]);
                AStaff.NextOfKin = Convert.ToString(DB.DataTable.Rows[Index]["Next_of_Kin"]);
                AStaff.PhoneNo = Convert.ToString(DB.DataTable.Rows[Index]["Phone_Number"]);
                //add the record to private data member
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        }
        //public property for this count 
        public clsStaff ThisStaff { get; set; }
    }
}