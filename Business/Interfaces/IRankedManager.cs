using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IRankedManager
    {
        public void StartSearching(int userid);
        public void StopSearching(int userid);
        public void LookForGame();
        public bool FindUserInGame(int userid);
    }
}
