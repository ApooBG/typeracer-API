using DAL.Data;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Handlers
{
    public class UserHandler : IUserHandler
    {
        List<User> users;
        List<MainPage> activeUsers;
        List<string> tryToTest;

        public UserHandler()
        {
            users = new List<User>();
            activeUsers = new List<MainPage>();
            tryToTest = new List<string>();

        }

        public void ChangePassword(string name, string password)
        {
            foreach (User user in users)
            {
                if (user.Name == name)
                {
                    // user.ChangePassword(password);
                    tryToTest.Add(password);
                }
            }
        }

        public List<User> GetUsers()
        {
            TyperacerContext context;
            using (context = new TyperacerContext())
            {
                var listOfUsers = context.Users;
                users.Clear();
                foreach (User user in listOfUsers)
                {
                    users.Add(user);
                }
            }
            context.Dispose();
            return users;


        }

        public void CreateUser(string username, string password, string email, string name, string country, string rank)
        {
            using (TyperacerContext context = new TyperacerContext())
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
                context.Users.Add(u);
                context.SaveChanges();
            }

        }

        public User FindUser(string username, string password)
        {
            User u = null;
            TyperacerContext context;
            using (context = new TyperacerContext())
            {
                var listOfUsers = context.Users
                      .Where(p => p.Username == username && p.Password == password);
                foreach (User user in listOfUsers)
                {
                    u = user;
                    break;
                }
              }
            context.Dispose();
            return u;


        }

        public User GetUser(int id)
        {
            TyperacerContext context;
            User u = null;

            using (context = new TyperacerContext())
            {
                var listOfUsers = context.Users
                      .Where(p => p.ID == id);
                foreach (User user in listOfUsers)
                {
                    u = user;
                    break;
                }

            }

            context.Dispose();
            return u;

        }

        public void MakePlayerActive(int id)
        {
            User user = GetUser(id);
            MainPage activeUser = new MainPage()
            { UserID = id,
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

        public string TypeRacerText(int id)
        {
            string[] Data = {"If we burn our wings flying too close to the sun; if the moment of glory is over before it's begun; if the dream is won though everything is lost, we will pay the price but we will not count the cost.",
                "Frodo and Sam stood as if enchanted. The wind puffed out. The leaves hung silently again on stiff branches. There was another burst of song, and then suddenly, hopping and dancing along the path, there appeared above the reeds an old battered hat with a tall crown and a long blue feather stuck in the band.",
                "For the days of my life have vanished like smoke, and my bones are parched like ash, and let all my impurities be as fuel for that fire until nothing remains but the light alone.",
                "Then we saw him pick up all the things that were down. He picked up the cake, and the rake, and the gown, and the milk, and the strings, and the books, and the dish, and the fan, and the cup, and the ship, and the fish.",
                "The place to improve the world is first in one's own heart and head and hands, and then to work outward from there. Other people can talk about how to expand the destiny of mankind. I just want to talk about how to fix a motorcycle. I think that what I have to say has more lasting value.",
                "Without some flexibility in our definitions we'll remain forever stuck with the same old knee-jerk reactions, or worse, slide into complete apathy.",
                "Sometimes it seems like we're all living in some kind of prison, and the crime is how much we hate ourselves. It's good to get really dressed up once in a while, and admit the truth - that when you really look closely, people are so strange and so complicated that they're actually beautiful. Possibly even me.",
                "I drew the blankets over my head and tried to think of Christmas. But the grey face still followed me. It murmured, and I understood that it desired to confess something. I felt my soul receding into some pleasant and vicious region; and there again I found it waiting for me.",
                "I've noticed that about your people, Doctor. You find it easier to understand the death of one than the death of a million. You speak about the objective hardness of the Vulcan heart yet how little room there seems to be in yours.",
                "I needed all the feelings to stop boiling like a pot of dal and be cool enough for me to taste them. " };
            return Data[id];
        }

        public int ChooseText()
        {
            Random random = new Random();
            return random.Next(0, 11);
        }
    }
}
