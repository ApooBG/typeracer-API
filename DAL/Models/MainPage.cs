using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class MainPage
    {
        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public int wpm { get; set; }
        public int image { get; set; }
    }
}
