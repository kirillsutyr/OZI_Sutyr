using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OZI_lab1
{
    public class  User
    {
        [Key]
        public string Name { get; set; }
        public int PasswordLength { get; set; }
        public string Password { get; set; }
        public bool Blocked { get; set; }
        public bool Restriction { get; set; }

        public string Role { get; set; }
    }
}
