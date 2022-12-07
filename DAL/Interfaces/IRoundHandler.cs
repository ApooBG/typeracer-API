using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRoundHandler
    { 
        public void CreateRound(Round r);
        public void UpdateRound(Round r);
        public Round GetRoundByGameID(int gameID);
        public Round GetRound(int userID);
        public Game GetGame(int userID);
    }
}
