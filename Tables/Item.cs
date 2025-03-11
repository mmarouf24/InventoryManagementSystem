using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class Item
    {
        public Item()
        {
            ReleaseOrderDetails = new HashSet<ReleaseOrderDetail>();
            Stocks = new HashSet<Stock>();
            StockTransferDetails = new HashSet<StockTransferDetail>();
            SupplyOrderDetails = new HashSet<SupplyOrderDetail>();
        }

        public int ItemID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        [Required]
        [MaxLength(50)]
        public string Unit { get; set; }
        public virtual ICollection<ReleaseOrderDetail> ReleaseOrderDetails { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }

        public virtual ICollection<StockTransferDetail> StockTransferDetails { get; set; }

        public virtual ICollection<SupplyOrderDetail> SupplyOrderDetails { get; set; }


    }
}
