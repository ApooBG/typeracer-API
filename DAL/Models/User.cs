using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class User
    {
#nullable enable
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }  
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }   
        public string? Age { get; set; }   
        public string? Country { get; set; }
        public DateTime joined { get; set; }
#nullable disable
    }
}
