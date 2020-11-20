using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    {
        public static string Password { get; set; } 
       
        [CompareProperty("Password",ErrorMessage ="password and confirm password must match")]
        public static string ConfirmPassword { get; set; }

    }
}
