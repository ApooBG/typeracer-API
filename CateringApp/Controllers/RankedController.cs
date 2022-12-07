using Business.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CateringApp.Controllers
{
    public class RankedController : Controller
    {
        IRankedManager _manager;

        public RankedController(IRankedManager _manager)
        {
            this._manager = _manager;
        }

        [HttpPost]
        [Route("StartSearching")]
        public void StartSearching(int userid)
        {
            _manager.StartSearching(userid);
        }

        [HttpPost]
        [Route("StopSearching")]
        public void StopSearching(int userid)
        {
            _manager.StopSearching(userid);
        }

        [HttpPost]
        [Route("LookForGame")]
        public void LookForGame()
        {
            _manager.LookForGame();
        }

        [HttpGet]
        [Route("FindUserInGame")]
        public bool FindUserInGame(int userid)
        {
            return _manager.FindUserInGame(userid);
        }


    }
}
