using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FoxCoinProject.Models
{
    public class TransAction
    {
        [Key]
        public long TransId { get; set; }
        public UserAccount FromUser { get; set; }
        public UserAccount ToUser { get; set; }
        public decimal Amount { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
