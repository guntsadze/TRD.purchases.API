using System;
using System.ComponentModel.DataAnnotations;

namespace trd.purchases.API.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public Guid DepartmentId { get; set; }

        [RegularExpression("^[0-9]*$")] // Ensure PersonalNumber consists of numbers only
        public string PersonalNumber { get; set; }
    }
}
