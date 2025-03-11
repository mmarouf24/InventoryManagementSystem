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
        public int ReleaseOrderID { get; set; }

        public int WarehouseID { get; set; }

        public int CustomerID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderNumber { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }
    }
}
