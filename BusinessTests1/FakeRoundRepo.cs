using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTests1
{
    public class FakeRoundRepo : IRoundHandler
    {
        public List<Game> listOfGames;
        public List<Round> listOfRounds;

        public FakeRoundRepo(List<Game> listOfGames, List<Round> listOfRound)
        {
            this.listOfGames = listOfGames;
            this.listOfRounds = listOfRound;
        }


        public void CreateRound(Round r)
        {
            listOfRounds.Add(r);
        }

        public Game GetGame(int userID)
        {
            return this.listOfGames.Find(p => p.User1ID == userID || p.User2ID == userID && p.Status == "Active");
        }

        public Round GetRound(int userID)
        {
            throw new NotImplementedException();
        }

        public Round GetRoundByGameID(int gameID)
        {
            return this.listOfRounds.Find(p => p.GameID == gameID);
        }

        public void UpdateRound(Round r)
        {

            int index = -1;
            foreach (Round r1 in listOfRounds)
            {
                index++;
                if (r1.RoundID == r.RoundID)
                {
                    listOfRounds.RemoveAt(index);
                    listOfRounds.Insert(index, r);
                    break;
                }
            }
        }
    }
}
