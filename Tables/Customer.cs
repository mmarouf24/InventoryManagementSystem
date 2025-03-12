using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagementSystem.Tables
{
    public class Customer
    {
        public Customer()
        {
            ReleaseOrders = new HashSet<ReleaseOrder>();
        }

        public int CustomerID { get; set; }
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
        public virtual ICollection<ReleaseOrder> ReleaseOrders { get; set; }
    }
}
