using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CateringApp_Tests
{
    public class FakeUserRepository : IUserHandler
    {
        public List<User> listOfUsers;

        public FakeUserRepository (List<User> listOfUsers)
        {
            this.listOfUsers = listOfUsers;
        }
        public void ChangePassword(string name, string password)
        {
            throw new NotImplementedException();
        }

        public int ChooseText()
        {
            throw new NotImplementedException();
        }

        public void CreateUser(string username, string password, string email, string name, string country, string rank)
        {
            User u = new User()
            {
                Username = username,
                Password = password,
                Email = email,
                Name = name,
                Country = country
            };
            listOfUsers.Add(u);
        }

        public User FindUser(string username, string password)
        {
            throw new NotImplementedException();
        }

        public List<MainPage> GetPlayersInMain()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void MakePlayerActive(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveUserFromMain(int id)
        {
            throw new NotImplementedException();
        }

        public string TypeRacerText(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateWPM(int id, int wpm)
        {
            throw new NotImplementedException();
        }
    }
}
