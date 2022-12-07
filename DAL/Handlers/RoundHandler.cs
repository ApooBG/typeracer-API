using DAL.Data;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Handlers
{
    public class RoundHandler : IRoundHandler
    {
        public Round GetRoundByGameID(int GameID)
        {
            TyperacerContext context;
            using (context = new TyperacerContext())
            {
                return context.Rounds.First(p => p.GameID == GameID);
            }
        }

        public void CreateRound(Round r)
        {
            TyperacerContext context;
            using (context = new TyperacerContext())
            {
                context.Rounds.Add(r);
                context.SaveChanges();
            }
        }

        public void UpdateRound(Round r)
        {
            TyperacerContext context;
            using (context = new TyperacerContext())
            {
                context.Rounds.Update(r);
                context.Dispose();
            }
        }
        public Round GetRound(int userID)
        {
            TyperacerContext context;
            using (context = new TyperacerContext())
            {
                try
                {
                    Game g = context.Games.First(p => p.Status == "Active" && p.User1ID == userID || p.User2ID == userID);
                    if (g != null)
                    {
                        return context.Rounds.First(p => p.GameID == g.GameID);
                    }
                }
                catch
                {

                }
                return null;
            }
        }

        public Game GetGame(int userID)
        {
            TyperacerContext context;
            using (context = new TyperacerContext())
            {
                try
                {
                    return context.Games.First(p => p.Status == "Active" && p.User1ID == userID || p.User2ID == userID);
                }

                catch
                {
                    return null;
                }
            }
        }
    }
}

