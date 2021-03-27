using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MyStorageSite.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Empty name")] //обов'язкове поле
        public string Name { get; set; }
        [Required(ErrorMessage = "Empty phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Empty address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Empty email")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = "Confirmation error")]
        public string ConfirmPassword { get; set; }
    }
}
