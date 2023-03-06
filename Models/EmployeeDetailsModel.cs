using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class EmployeeDetailsModel
    {
        public int EmpId { get; set; }
        [Required]
         [MaxLength(10)]
        public string? Name { get; set; }
        [Required]
        [Range(1,100, ErrorMessage ="Age must be between 1-100 in years.")]
        public string? Age { get; set; }
        [Required]
         [Range(1,100000, ErrorMessage ="Salary must be between 1-100000.")]
        public string? salary { get; set; }
        [Required]
          [MaxLength(10)]
        public string? Designation { get; set; }

    }
}