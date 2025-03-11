using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class ReleaseOrderDetail
    {
        public int ReleaseOrderDetailID { get; set; }

        public int ReleaseOrderID { get; set; }

        public int ItemID { get; set; }

        public int Quantity { get; set; }

    }
}
