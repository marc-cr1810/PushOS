using PushOS.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushOS.System.Users
{
    internal class Users
    {
        private static readonly string UsersFile = @"0:\etc\passwd";
        private static List<User> users;
        private static readonly uint RootUserID = 0;
        private static uint NextSystemUserID = 1;
        private static uint NextUserID = 1000;

        public static void LoadUsers()
        {
            users = new List<User>();

            if (!File.Exists(UsersFile))
            {
                Directory.CreateDirectory(@"0:\etc\");
                File.Create(UsersFile);

                if (!Create("root", "admin", UserRole.Admin))
                {
                    Console.WriteLine("Failed to create the root user");
                    return;
                }
            }
        }

        public static bool Create(string username, string password, UserRole role)
        {
            if (Get(username) != null)
            {
                Console.WriteLine($"{username} already exists");
                return false;
            }

            if (role == UserRole.Admin)
            {
                Console.WriteLine("Only 1 administrator user can exist");
                return false;
            }

            var passwordHash = Sha256.Hash(password);
            var id = role switch
            {
                UserRole.Admin => RootUserID,
                UserRole.System => NextSystemUserID++,
                UserRole.User => NextUserID++,
                _ => throw new NotImplementedException(),
            };

            User user = new User(id, username, passwordHash, role);
            users.Add(user);
            //using (StreamWriter sw = File.AppendText(UsersFile))
            //{
            //    sw.WriteLine($"{id}:{username}:{passwordHash}:{(int)role}");
            //}
            return true;
        }

        public static User Get(string username)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Name == username)
                {
                    return users[i];
                }
            }

            throw new Exception("Unknown username");
        }
    }
}
