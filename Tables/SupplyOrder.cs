using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class SupplyOrder
    {
        public SupplyOrder()
        {
            SupplyOrderDetails = new List<SupplyOrderDetail>();
        }

        public int SupplyOrderID { get; set; }

        public int WarehouseID { get; set; }

        public int SupplierID { get; set; }

        [Required]
        [MaxLength(50)]
        public string OrderNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Warehouse Warehouse { get; set; }
        public virtual ICollection<SupplyOrderDetail> SupplyOrderDetails { get; set; }


    }
}
