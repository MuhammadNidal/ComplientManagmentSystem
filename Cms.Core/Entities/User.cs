using System;
using System.ComponentModel.DataAnnotations;

namespace ComplaintManagementSystem.Domain.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }  // Auto-incremented primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
