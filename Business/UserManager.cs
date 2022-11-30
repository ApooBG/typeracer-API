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
    public class UserManager : IUserManager
    {
        private readonly IUserHandler _userHandler;
        List<User> users;

        public UserManager(IUserHandler _userHandler)
        {
            this._userHandler = _userHandler;
            this.users = new List<User>();
        }

        public void ChangePassword(string username, string password)
        {
            _userHandler.ChangePassword(username, password);
        }

        public List<User> GetUsers()
        {
            return _userHandler.GetUsers();
        }

        public void CreateUser(string username, string password, string email, string name, string country, string rank)
        {
            _userHandler.CreateUser(username, password, email, name, country, rank);
        } 

        public User FindUser(string username, string password)
        {
            return _userHandler.FindUser(username,password);
        }
        public string TypeRacerText(int id)
        {
            return _userHandler.TypeRacerText(id);
        }
        public int ChooseText()
        {
            return _userHandler.ChooseText();
        }
        public User GetUser(int id)
        {
            return _userHandler.GetUser(id);
        }
        public void MakePlayerActive(int id)
        {
            _userHandler.MakePlayerActive(id);
        }
        public List<MainPage> GetPlayersInMain()
        {
            return _userHandler.GetPlayersInMain();
        }
        public void UpdateWPM(int id, int wpm)
        {
            _userHandler.UpdateWPM(id, wpm);
        }

        public void RemoveUserFromMain(int id)
        {
            _userHandler.RemoveUserFromMain(id);
        }

    }
}
