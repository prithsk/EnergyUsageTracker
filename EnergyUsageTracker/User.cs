using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyUsageTracker
{
        public class User
        {
            public int UserID { get; set; }
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Preferences { get; set; }

            public User(int userID, string userName, string email, string preferences)
            {
                UserID = userID;
                UserName = userName;
                Email = email;
                Preferences = preferences;
            }

            public void AddUser()
            {

                Console.WriteLine($"User {UserName} added.");
            }

            public void EditUser(string newEmail, string newPreferences)
            {
                Email = newEmail;
                Preferences = newPreferences;
                Console.WriteLine($"User {UserName} updated.");
            }
        }
    }

