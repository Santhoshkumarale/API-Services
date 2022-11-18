using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Models
{
     public  class RegisterVM
    {
        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = " PhoneNumberis required")]
        [MaxLength(10,ErrorMessage = "PhoneNumber Must contain 10 Digits")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Passsword { get; set; }
        [Required(ErrorMessage = "Role  is required")]
        public string Role { get; set; }
    }
}
