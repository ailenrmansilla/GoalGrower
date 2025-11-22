using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GoalGrower.Models;

namespace GoalGrower.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Description { get; set; }

        [Required]
        public string Type { get; set; } = string.Empty; // e.g., "income" or "expense"

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string UserId { get; set; } = string.Empty;  // FK pointing to IdentityUser.Id
        public User User { get; set; } = null!;             // Navigation property

        [ForeignKey("Goal")]
        public int? GoalId { get; set; }

        // Navigation properties
        public Goal? Goal { get; set; }
    }
}
