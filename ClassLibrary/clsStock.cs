using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public clsStock()
        {
        }

        public string Classification { get; set; }
        public string Genre { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ShelfLocation { get; set; }
        public int StockID { get; set; }

        public bool Find(clsStock aStock)
        {
            //always return true
            return true;
        }
    }
}