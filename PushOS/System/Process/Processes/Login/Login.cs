using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PushOS.System.Process.Processes
{
    internal class Login : Process
    {
        public Login() 
            : base("login", ProcessType.Program)
        {
            Console.WriteLine();
            Console.WriteLine("Push OS ver 0.1");
            while (!LoginPrompt())
            {
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("Authentication failure!");
            }

            Console.WriteLine("Logged in!");
        }

        private bool LoginPrompt()
        {
            Console.WriteLine();
            Console.Write("login: ");
            var username = Console.ReadLine();
            Console.Write("password: ");
            var password = Console.ReadLine();

            return Users.Validate(username, password);
        }
    }
}
