using Business.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CateringApp.Controllers
{
    public class RoundController : Controller
    {
        IRoundManager _roundManager;
        public RoundController(IRoundManager _roundManager)
        {
            this._roundManager = _roundManager;
        }

        [HttpPost]
        [Route("CreateRound")]
        public void CreateRound(int userid)
        {
            _roundManager.CreateRound(userid);
        }
        [HttpPost]
        [Route("UpdateRankedWPM")]
        public void UpdateWPM(int userID, int wpm)
        {
            _roundManager.UpdateWPM(userID, wpm);
        }
        [HttpPost]
        [Route("UpdateAccuracy")]
        public void UpdateAccuracy(int userID, int accuracy)
        {
            _roundManager.UpdateAccuracy(userID, accuracy);
        }
        [HttpPost]
        [Route("UpdateTotalScore")]
        public void UpdateTotalScore(int userID, int totalScore)
        {
            _roundManager.UpdateTotalScore(userID, totalScore);
        }
        [HttpPost]
        [Route("FinishGame")]
        public void FinishGame(int userID)
        {
            _roundManager.FinishRound(userID);
        }
        [HttpGet]
        [Route("GetRound")]
        public Round GetRound(int userID)
        {
            return _roundManager.GetRound(userID);
        }
        [HttpGet]
        [Route("GetGame")]
        public Game GetGame(int userID)
        {
            return _roundManager.GetGame(userID);
        }
    }
}
