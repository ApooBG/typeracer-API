using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUserHandler
    {
        public void UpdateUser(User u);
        public List<User> GetUsers();
        public void CreateUser(User u);
        public User FindUser(string username, string password);
        public User GetUser(int id);
        public User GetUserByUsername(string username);
        public string TypeRacerText(int id);
        public int ChooseText();

    }
}
