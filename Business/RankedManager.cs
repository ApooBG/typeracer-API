using Business.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class RankedManager : IRankedManager
    {
        private readonly IRankedHandler _handler;


        public List<Ranked> listOfUsers = new List<Ranked>();

        public RankedManager(IRankedHandler _rankedHandler)
        {
            this._handler = _rankedHandler;
        }
        public void StartSearching(int userid)
        {
            Ranked u = _handler.FindRankedUser(userid);
            if (u != null)
                listOfUsers.Add(u);
        }
        public void StopSearching(int userid)
        {
            try
            {
                listOfUsers.Remove(listOfUsers.Find(p => p.UserID == userid));
            }
            catch
            {

            }
        }
        public void LookForGame()
        {

            foreach (Ranked u1 in listOfUsers)
            {
                foreach (Ranked u2 in listOfUsers)
                {
                    if (u1 != u2)
                    {
                        if (u1.Rank == u2.Rank)
                        {
                            if (FindUserInGame(u1.UserID) == false && FindUserInGame(u2.UserID) == false)
                            {
                                Game game = new Game()
                                {
                                    User1ID = u1.UserID,
                                    User2ID = u2.UserID,
                                    Status = "Active"
                                };

                                _handler.LookForGame(game);
                                listOfUsers.Remove(u1);
                                listOfUsers.Remove(u2);

                                return;
                            }
                        }
                    }
                }
            }
        }
        public bool FindUserInGame(int userid)
        {
            return _handler.FindUserInGame(userid);
        }
    }
}
