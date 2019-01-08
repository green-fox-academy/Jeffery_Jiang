using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoxCoinProject.Models
{
    public class UserAccount
    {
        [StringLength(30,MinimumLength = 2)]
        [Required]
        public string Name { get; set; }
        [Key]
        public long UserId { get; set; }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}
