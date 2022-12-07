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
        public List<User> users;
        public List<MainPage> activeUsers;

        public UserManager(IUserHandler _userHandler)
        {
            this._userHandler = _userHandler;
            this.users = new List<User>();
            this.activeUsers = new List<MainPage>();
        }

        public void ChangePassword(string username, string password)
        {
            User u = _userHandler.GetUserByUsername(username);
            u.Password = password;
            _userHandler.UpdateUser(u);
        }

        public List<User> GetUsers()
        {
            return _userHandler.GetUsers();
        }

        public void CreateUser(string username, string password, string email, string name, string country, string rank)
        {
            User u = new User()
            {
                Username = username,
                Password = password,
                Email = email,
                Name = name,
                Country = country,
                joined = DateTime.Now
            };
            _userHandler.CreateUser(u);
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
            User user = GetUser(id);
            MainPage activeUser = new MainPage()
            {
                UserID = id,
                Username = user.Username,
                wpm = 0
            };
            if (activeUsers.Find(u => u.Id == id) == null)
                activeUsers.Add(activeUser);
        }
        public List<MainPage> GetPlayersInMain()
        {
            return this.activeUsers;
        }


        public void UpdateWPM(int id, int wpm)
        {
            int i = -1;
            foreach (MainPage user in GetPlayersInMain())
            {
                i++;
                if (user.UserID == id)
                {
                    user.wpm = wpm;
                    return;
                }
            }
        }

        public void RemoveUserFromMain(int id)
        {
            foreach (MainPage user in GetPlayersInMain())
            {
                if (user.UserID == id)
                {
                    activeUsers.Remove(user);
                    return;
                }
            }
        }
    }
}
