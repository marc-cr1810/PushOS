using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushOS.System.Users
{
    internal enum UserRole
    {
        Admin,
        System,
        User
    }

    internal class User
    {
        public uint ID { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public UserRole Role { get; private set; }

        public User(uint id, string username, string password, UserRole role)
        {
            ID = id;
            Name = username;
            Password = password;
            Role = role;
        }
    }
}
