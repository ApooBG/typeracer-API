using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Round
    {
#nullable enable
        public int GameID { get; set; }
        public int RoundID { get; set; }
        public int? WPM1 { get; set; }
        public int? Accuracy1 { get; set; }
        public int? TotalScore1 { get; set; }
        public int? WPM2 { get; set; }
        public int? Accuracy2 { get; set; }
        public int? TotalScore2 { get; set; }
        public int? WinnerID { get; set; }

#nullable disable
    }
}
