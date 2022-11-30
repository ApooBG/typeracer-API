using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUserManager
    {
        public void ChangePassword(string username, string password);
        public List<User> GetUsers();
        public void CreateUser(string username, string password, string email, string name, string country, string rank);
        public User FindUser(string username, string password);
        public User GetUser(int id);
        public void MakePlayerActive(int id);
        public List<MainPage> GetPlayersInMain();
        public void UpdateWPM(int id, int wpm);
        public void RemoveUserFromMain(int id);
        public string TypeRacerText(int id);
        public int ChooseText();

    }
}
