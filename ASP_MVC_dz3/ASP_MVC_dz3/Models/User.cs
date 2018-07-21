using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_MVC_dz3.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "The length of the log-in must be from 3 to 20 characters")]
        public string Login { get; set; }

        [StringLength(20, MinimumLength = 3, ErrorMessage = "The length of the Password must be between 3 and 20 characters")]
        public string Password { get; set; }
       
        [RegularExpression(@"^[-\w.]+@([A-z0-9][-A-z0-9]+\.)+[A-z]{2,4}$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        
        [RegularExpression(@"^(\s*)?(\+)?([-_():= +]?\d[-_():= +]?){10,14}(\s*)?$", ErrorMessage = "Invalid phone address")]
        public string Phone { get; set; }
        public Role Role = new Role();
    }
}