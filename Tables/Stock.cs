using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class Stock
    {
        public int StockID { get; set; }

        public int WarehouseID { get; set; }

        public int ItemID { get; set; }

        public int Quantity { get; set; }
    }
}
