using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Models;
using CateringApp_Tests;

namespace DAL.Handlers.Tests
{
    [TestClass()]
    public class UserHandlerTests
    {
        [TestMethod()]
        public void UserHandlerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ChangePasswordTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUsersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void CreateUserTest()
        {
            string username = "ApooBG";
            string password = "parola";
            string email = "this is email";


            User u = new User()
            {
                Username = username,
                Password = password,
                Email = email,
                Name = "dsa",
                Country = "dsa"
            };

            FakeUserRepository fakeRepo = new FakeUserRepository(new List<User>() { });
            UserHandler _handler = new UserHandler(fakeRepo);

            _handler.CreateUser(u.Username, u.Password, u.Email, "dsa", "dsa", "dsa");

            CollectionAssert.Contains(fakeRepo.listOfUsers, u);
        }

        [TestMethod()]
        public void FindUserTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUserTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void MakePlayerActiveTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetPlayersInMainTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateWPMTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void RemoveUserFromMainTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void TypeRacerTextTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ChooseTextTest()
        {
            Assert.Fail();
        }
    }
}