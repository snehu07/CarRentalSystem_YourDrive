using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YourDrive.Models
{
    public class Employee
    {
        [Key] public int EmployeeId { get; set; }

        [Column(TypeName = "nvarchar(250)")] [Required(ErrorMessage = "This field is required.")] [DisplayName("Full Name")] public string FullName { get; set; }

        [Column(TypeName = "varchar(10)")] [DisplayName("Address")] public string Address { get; set; }

        [Column(TypeName = "varchar(100)")] public string City { get; set; }
        [Column(TypeName = "nvarchar(250)")] [Required(ErrorMessage = "This field is required.")] [DisplayName("State")] public string State { get; set; }
        [Column(TypeName = "nvarchar(250)")] [Required(ErrorMessage = "This field is required.")] [DisplayName("Password")] public string Password { get; set; }
        [Column(TypeName = "nvarchar(250)")] [Required(ErrorMessage = "This field is required.")] [DisplayName("Confirm Password")] public string ConfirmPassword { get; set; }
        [Column(TypeName = "nvarchar(250)")] [Required(ErrorMessage = "This field is required.")] [DisplayName("Email")] public string Email { get; set; }




    }
}
