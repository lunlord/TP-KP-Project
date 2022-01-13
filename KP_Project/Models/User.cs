using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KP_Project.Models
{
    public class User
    {
        [Display(Name = "User ID")]
        [Required(ErrorMessage ="You need to enter User ID")]
        public int UserId { get; set; }

        [Display(Name = "Login")]
        [Required(ErrorMessage = "You need to enter Login")]
        public int Login { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You need to enter Password")]
        [DataType(DataType.Password)]
        [StringLength(20,MinimumLength = 8, ErrorMessage ="Your password is short")]
        public int Password { get; set; }

        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Required(ErrorMessage = "You need to enter Phone number")]
        public int Phone_number { get; set; }

        [Display(Name = "Adress")]
        [Required(ErrorMessage = "You need to enter Adress")]
        public int Adress { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "You need to enter Email")]
        public int Email { get; set; }
    }
}
