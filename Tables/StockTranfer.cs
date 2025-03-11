using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tables
{
    public class StockTranfer
    {
        [Key]
        public int TransferID { get; set; }

        public int FromWarehouseID { get; set; }

        public int ToWarehouseID { get; set; }

        [Column(TypeName = "date")]
        public DateTime TransferDate { get; set; }
    }
}
