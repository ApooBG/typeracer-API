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
    public class RankedManagerTests
    {
        [TestMethod()]
        public void StartSearching() //when a user starts searching for a ranked  game he will be sent here
        {
            Ranked u = new Ranked()
            {
                UserID = 1,
                IsSearching = true,
                Rank = "silver"
            };

            FakeRankedRepo fakeRepo = new FakeRankedRepo(new List<Ranked>() { u });
            RankedManager _manager = new RankedManager(fakeRepo);

            _manager.StartSearching(1);

            Assert.AreEqual(_manager.listOfUsers[0], u);
        }


        [TestMethod()]
        public void StopSearching() //when a user stops searching for a ranked game
        {
            Ranked u = new Ranked()
            {
                UserID = 1,
                IsSearching = true,
                Rank = "silver"
            };

            FakeRankedRepo fakeRepo = new FakeRankedRepo(new List<Ranked>() { u });
            RankedManager _manager = new RankedManager(fakeRepo);
            _manager.listOfUsers.Add(u);

            _manager.StopSearching(1);

            CollectionAssert.DoesNotContain(_manager.listOfUsers, u);
        }

        [TestMethod()]
        public void LookForGame() //when two users from the same rank starts searching the system have to create a game
        {
            Ranked u1 = new Ranked()
            {
                UserID = 1,
                IsSearching = true,
                Rank = "silver"
            };

            Ranked u2 = new Ranked()
            {
                UserID = 2,
                IsSearching = true,
                Rank = "silver"
            };

            FakeRankedRepo fakeRepo = new FakeRankedRepo(new List<Ranked>() { u1,u2 }, new List<Game>() { });
            RankedManager _manager = new RankedManager(fakeRepo);
            _manager.listOfUsers.Add(u1);
            _manager.listOfUsers.Add(u2);


            _manager.LookForGame();

            Assert.AreEqual(fakeRepo.listOfGames[0].User1ID, u1.UserID);
        }
    }
}
