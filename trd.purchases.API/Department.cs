using System;
using System.ComponentModel.DataAnnotations;

namespace trd.purchases.API.Models
{
    public class Department
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string DepName { get; set; }
    }
}
