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
    public class RankedHandler : IRankedHandler
    {

        public Ranked FindRankedUser(int userid)
        {
            TyperacerContext context;
            using (context = new TyperacerContext())
            {

                Ranked user = context.Rankeds.First(p => p.UserID == userid);

                if (user != null)
                    return user;
            }
            context.Dispose();
            return null;
        }


        public void LookForGame(Game game)
        {
            TyperacerContext context;
            using (context = new TyperacerContext())
            {

                context.Games.Add(game);
                context.SaveChanges();

            }
            context.Dispose();
        }


        public bool FindUserInGame(int userid)
        {
            TyperacerContext context;
            using (context = new TyperacerContext())
            {
                try
                {
                    Game g1 = context.Games.First(p => p.User1ID == userid && p.Status == "Active");
                    Game g2 = context.Games.First(p => p.User2ID == userid && p.Status == "Active");
                    if (g1 == null && g2 == null)
                    {
                        return true;
                    }

                }

                catch
                {
                    return false;
                }
            }

            return true;
        }



    }
}
