using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class StockTransfer
    {
        public StockTransfer()
        {
            StockTransferDetails = new HashSet<StockTransferDetail>();
        }
        [Key]
        public int TransferID { get; set; }

        public int FromWarehouseID { get; set; }

        public int ToWarehouseID { get; set; }

        [Column(TypeName = "date")]
        public DateTime TransferDate { get; set; }
        public virtual ICollection<StockTransferDetail> StockTransferDetails { get; set; }

        public virtual Warehouse FromWarehouse { get; set; }

        public virtual Warehouse ToWarehouse { get; set; }
    }
}
