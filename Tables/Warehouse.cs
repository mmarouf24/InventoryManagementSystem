using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class Warehouse
    {
        public Warehouse()
        {
            ReleaseOrders = new HashSet<ReleaseOrder>();
            Stocks = new HashSet<Stock>();
            StockTransfers = new HashSet<StockTransfer>();
            StockTransfers1 = new HashSet<StockTransfer>();
            SupplyOrders = new HashSet<SupplyOrder>();
        }
        public int WarehouseID { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Address { get; set; }

        [Required]
        [MaxLength(100)]
        public string Manager { get; set; }

        public virtual ICollection<ReleaseOrder> ReleaseOrders { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }

        public virtual ICollection<StockTransfer> StockTransfers { get; set; }

        public virtual ICollection<StockTransfer> StockTransfers1 { get; set; }

        public virtual ICollection<SupplyOrder> SupplyOrders { get; set; }


    }
}
