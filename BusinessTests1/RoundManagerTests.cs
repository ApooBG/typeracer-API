using Business;
using DAL.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTests1
{
    [TestClass()]
    public class RoundManagerTests
    {
        [TestMethod()]
        public void StartSearching() //when a user starts searching for a ranked  game he will be sent here
        {
            User user = new User()
            {
                ID = 1,
                Username = "ApooBG",
                Password = "password",
                Email = "thisismyemail@gmail.com",
                Name = "Ruslan",
                Country = "Bulgaria"
            };

            Ranked u = new Ranked()
            {
                UserID = 1,
                IsSearching = true,
                Rank = "silver"
            };

            Game g = new Game()
            {
                GameID = 1,
                User1ID = 1,
                User2ID = 2
            };

            FakeRoundRepo fakeRepo = new FakeRoundRepo(new List<Game>() { g }, new List<Round>() { });
            RoundManager _manager = new RoundManager(fakeRepo);

            _manager.CreateRound(1);

            CollectionAssert.Equals(fakeRepo.listOfRounds[0].RoundID, 1);
        }

        [TestMethod()]
        public void FinishGame() //when the game can be ended
        {
            User user1 = new User()
            {
                ID = 1,
                Username = "ApooBG",
                Password = "password",
                Email = "thisismyemail@gmail.com",
                Name = "Ruslan",
                Country = "Bulgaria"
            };

            User user2 = new User()
            {
                ID = 2,
                Username = "ApooBG2",
                Password = "password2",
                Email = "thisismyemail2@gmail.com",
                Name = "Ruslan2",
                Country = "Bulgaria2"
            };

            Game game = new Game()
            {
                GameID = 1,
                User1ID = 1,
                User2ID = 2,
                Status = "Active"
            };

            Round round1 = new Round()
            {
                GameID = 1,
                RoundID = 1,
                TotalScore1 = 50,
                TotalScore2 = 100
            };

            Round round2 = new Round()
            {
                GameID = 1,
                RoundID = 2,
                TotalScore1 = 50,
                TotalScore2 = 100
            };


            FakeRoundRepo fakeRepo = new FakeRoundRepo(new List<Game>() { game }, new List<Round>() { round1, round2 });
            RoundManager _manager = new RoundManager(fakeRepo);

            _manager.FinishRound(1);
            Assert.AreEqual(fakeRepo.listOfRounds[0].WinnerID, 3);


        }
    }
}
