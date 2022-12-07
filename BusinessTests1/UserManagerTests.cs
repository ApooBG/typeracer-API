using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using BusinessTests1;

namespace Business.Tests
{
    [TestClass()]
    public class UserManagerTests
    {

        [TestMethod()]
        public void CreateUserTest() //registering user
        {
            string username = "ApooBG";
            string password = "parola";
            string email = "thisismyemaiL@gmail.com";


            User u = new User()
            {
                Username = username,
                Password = password,
                Email = email,
                Name = "Ruslan",
                Country = "Bulgaria"
            };

            FakeUserRepo fakeRepo = new FakeUserRepo(new List<User>() { });
            UserManager _manager = new UserManager(fakeRepo);

            _manager.CreateUser(u.Username, u.Password, u.Email, "Ruslan", "Bulgaria", "active");

            CollectionAssert.Equals(fakeRepo.listOfUsers[0].Username, u.Username);
        }

        [TestMethod()]
        public void MakePlayersActive() // aplayer starts writing in the main page
        {
            User u = new User()
            {
                ID = 1,
                Username = "ApooBG",
                Password = "parola",
                Email = "thisismyemaiL@gmail.com",
                Name = "Ruslan",
                Country = "Bulgaria"
            };

            User u2 = new User()
            {
                ID = 2,
                Username = "ApooBG2",
                Password = "parola2",
                Email = "thisismysecondemail@gmail.com",
                Name = "Ivan",
                Country = "France"
            };

            FakeUserRepo fakeRepo = new FakeUserRepo(new List<User>() { u, u2 });
            UserManager _manager = new UserManager(fakeRepo);


            _manager.MakePlayerActive(1);

            CollectionAssert.Equals(_manager.activeUsers[0].Id, u.ID);
        }

        [TestMethod()]
        public void RemoveUserFromMain() // removed from the main page
        {
            User u = new User()
            {
                ID = 1,
                Username = "ApooBG",
                Password = "parola",
                Email = "thisismyemaiL@gmail.com",
                Name = "Ruslan",
                Country = "Bulgaria"
            };

            User u2 = new User()
            {
                ID = 2,
                Username = "ApooBG2",
                Password = "parola2",
                Email = "thisismysecondemail@gmail.com",
                Name = "Ivan",
                Country = "France"
            };

            FakeUserRepo fakeRepo = new FakeUserRepo(new List<User>() { u, u2 });
            UserManager _manager = new UserManager(fakeRepo);

            MainPage mainPageUser = new MainPage()
            {
                UserID = u.ID,
                Username = u.Username,
                wpm = 100
            };

            _manager.activeUsers.Add(mainPageUser);

            _manager.RemoveUserFromMain(1);

            CollectionAssert.DoesNotContain(_manager.activeUsers, mainPageUser);
        }
    }
}