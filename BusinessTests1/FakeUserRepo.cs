using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTests1
{
    public class FakeUserRepo : IUserHandler
    {
        public List<User> listOfUsers;
        public FakeUserRepo(List<User> listOfUsers)
        {
            this.listOfUsers = listOfUsers;
        }

        public int ChooseText()
        {
            throw new NotImplementedException();
        }

        public void CreateUser(User u)
        {
            listOfUsers.Add(u);
        }

        public User FindUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            return listOfUsers.Find(p => p.ID == id);
        }

        public User GetUserByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public string TypeRacerText(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User u)
        {

        }
    }
}
