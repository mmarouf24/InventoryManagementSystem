using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class ReleaseOrder
    {
        public ReleaseOrder()
        {
            ReleaseOrderDetails = new HashSet<ReleaseOrderDetail>();
        }
        public int ReleaseOrderID { get; set; }

        public int WarehouseID { get; set; }

        public int CustomerID { get; set; }

        [Required]
        [MaxLength(50)]
        public string OrderNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<ReleaseOrderDetail> ReleaseOrderDetails { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
