using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class SupplyOrderDetail
    {
        public int SupplyOrderDetailID { get; set; }

        public int SupplyOrderID { get; set; }

        public int ItemID { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "date")]
        public DateTime ProductionDate { get; set; }

        public int ExpirationPeriod { get; set; }

    }
}
