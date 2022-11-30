using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    [Keyless]
    public class Ranked
    {
#nullable enable
        public int UserID { get; set; }
        public bool IsSearching { get; set; }
        public string Rank { get; set; }

    }
}
