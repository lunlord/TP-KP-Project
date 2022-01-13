using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KP_Project.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int Login { get; set; }
        public int Password { get; set; }
        public int Phone_number { get; set; }
        public int Adress { get; set; }
        public int Email { get; set; }
    }
}
