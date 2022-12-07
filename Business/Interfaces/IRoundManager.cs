using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRoundManager
    {
        public void CreateRound(int userid);
        public void UpdateWPM(int userID, int wpm);
        public void UpdateAccuracy(int userID, int accuracy);
        public void UpdateTotalScore(int userID, int totalScore);
        public void FinishRound(int userID);
        public Round GetRound(int userID);
        public Game GetGame(int userID);
    }
}
