using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Repository.ViewModels
{
    public class UserEmp
    {
        public string EntityName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeFullName { get; set; }
        public string IdNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool? Gender { get; set; }
        public string Role { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
