using Business.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace CateringApp.Controllers
{
    public class UserController : Controller
    {
        IUserManager _userManager;
        public UserController(IUserManager _userManager)
        {
            this._userManager = _userManager;
        }

        [HttpGet]
        [Route("GetUsers")]
        public List<User> GetUsers()
        {
            return _userManager.GetUsers();
        }

        [HttpPost]
        [Route("ChangePassword")]
        public void ChangePassword(string username, string password)
        {
            try
            {
                _userManager.ChangePassword(username, password);
            }

            catch (Exception ex)
            {

            }
        }

        [HttpPost]
        [Route("RegisterUser")]
        public void CreateUser(string username, string password, string email, string name, string country, string rank)
        {
            _userManager.CreateUser(username, password, email, name, country, rank);
        }

        [HttpGet]
        [Route("FindUser")]
        public User FindUser(string username, string password)
        {
            return _userManager.FindUser(username, password);
        }

        [HttpGet]
        [Route("GetUser")]
        public User GetUser(int id)
        {
            return _userManager.GetUser(id);
        }
        [HttpPost]
        [Route("MakePlayerActive")]
        public void MakePlayerActive(int id)
        {
            _userManager.MakePlayerActive(id);
        }
        [HttpGet]
        [Route("GetPlayersInMain")]
        public List<MainPage> GetPlayersInMain()
        {
            return _userManager.GetPlayersInMain();
        }
        [HttpPost]
        [Route("UpdateWPM")]
        public void UpdateWPM(int id, int wpm)
        {
            _userManager.UpdateWPM(id, wpm);
        }

        [HttpPost]
        [Route("RemoveUserFromMain")]
        public void RemoveUserFromMain(int id)
        {
            _userManager.RemoveUserFromMain(id);
        }

    }
}
