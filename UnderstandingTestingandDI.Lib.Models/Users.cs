using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UnderstandingTestingandDI.Lib.Models
{
    public class Users
    {
        public Users()
        {
            Accounts = new HashSet<Account>();
        }


        [Key]
        public string UserId { get; set; } = Guid.NewGuid().ToString();

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
