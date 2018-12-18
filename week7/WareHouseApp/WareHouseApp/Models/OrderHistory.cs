using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace WareHouseApp.Models
{
    public class OrderHistory
    {
        [Key]
        public long OrderId { get; set; }
        public DateTime CreateAt { get; set; }
        public string CustomerName { get; set; }
    }
}
