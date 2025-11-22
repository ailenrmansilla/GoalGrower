using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GoalGrower.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public decimal BankAmount { get; set; }

        // Navigation properties
        public List<Transaction>? Transactions { get; set; }
        public List<Goal>? Goals { get; set; }
    }
}
