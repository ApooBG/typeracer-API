using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTests1
{
    internal class FakeRankedRepo : IRankedHandler
    {
        List<Ranked> listOfUsers;
        public List<Game> listOfGames;

        public FakeRankedRepo(List<Ranked> listOfUsers)
        {
            this.listOfUsers = listOfUsers;
        }

        public FakeRankedRepo(List<Ranked> listOfUsers, List<Game> listOfGames)
        {
            this.listOfUsers = listOfUsers;
            this.listOfGames = listOfGames;
        }


        public FakeRankedRepo(List<Game> listOfGames)
        {
            this.listOfGames = listOfGames;
        }


        public Ranked FindRankedUser(int userid)
        {
            try
            {
                return this.listOfUsers.Find(p => p.UserID == userid);
            }
            catch
            {
                return null;
            }

        }

        public bool FindUserInGame(int userid)
        {
            try
            {
                Game game = listOfGames.First(p => p.User1ID == userid || p.User2ID == userid);
                if (game != null)
                    return true;
            }
            catch
            {

            }
            return false;
        }

        public void LookForGame(Game game)
        {
            listOfGames.Add(game);
        }
    }
}
