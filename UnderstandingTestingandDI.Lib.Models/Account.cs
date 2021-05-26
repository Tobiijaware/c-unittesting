using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnderstandingTestingandDI.Lib.Models
{
    public class Account
    {
        [Key]
        public string AccountId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string UserId { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        [Required]
        public string AccountType { get; set; }
    }
}
