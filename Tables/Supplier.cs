using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class Supplier
    {
        public Supplier()
        {
            StockTransferDetails = new HashSet<StockTransferDetail>();
            SupplyOrders = new HashSet<SupplyOrder>();
        }
        public int SupplierID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(20)]
        public string? Phone { get; set; }

        [MaxLength(20)]
        public string? Fax { get; set; }

        [Required]
        [MaxLength(20)]
        public string Mobile { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        [MaxLength(255)]
        public string? Website { get; set; }
        public virtual ICollection<StockTransferDetail> StockTransferDetails { get; set; }

        public virtual ICollection<SupplyOrder> SupplyOrders { get; set; }
    }
}
