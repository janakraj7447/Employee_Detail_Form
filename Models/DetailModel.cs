 using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

public  class DetailModel
{
    [Required]
    public int UserId { get; set; }
    [StringLength(15,ErrorMessage ="Name should be of maximum 15 characters")]
    [Required]

    public string? Name { get; set; }

   [Required]
    public string? Age { get; set; }

[Required]
    public string? Salary { get; set; }
[Required]
    public string? Designation { get; set; }
}
