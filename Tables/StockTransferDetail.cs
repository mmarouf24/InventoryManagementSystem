using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class StockTransferDetail
    {
        [Key]
        public int TransferDetailID { get; set; }

        public int TransferID { get; set; }

        public int ItemID { get; set; }

        public int Quantity { get; set; }

        public int SupplierID { get; set; }

        [Column(TypeName = "date")]
        public DateTime ProductionDate { get; set; }

        public int ExpirationPeriod { get; set; }

    }
}
