using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRankedHandler
    {
        public Ranked FindRankedUser(int userid);
        public void LookForGame(Game game);
        public bool FindUserInGame(int userid);
    }
}
