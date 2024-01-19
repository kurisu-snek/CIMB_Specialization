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
        public int paymentDetailsid { get; set; }
        [Required]
        public string cardOwnerName { get; set; }
        [Required]
        [DataType(DataType.CreditCard)]
        [StringLength(16)]
        public string cardNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime expirationDate { get; set; }
        [Required]
        [StringLength(3)]
        public string securityCode { get; set; }
    }
}
