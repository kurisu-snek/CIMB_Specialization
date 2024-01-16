using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class ItemData
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string cardOwnerName { get; set; }
        [Required]
        public string cardNumber { get; set; }
        [Required]
        public string expirationDate { get; set; }
        [Required]
        public string securityCode { get; set; }
    }
}
