using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        public int Count { get; set; }
        public List<clsStock> StockList { get; set; }
        public clsStock ThisStock { get; set; }
    }
}