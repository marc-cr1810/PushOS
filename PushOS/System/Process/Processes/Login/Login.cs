using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushOS.System.Process.Processes
{
    internal class Login : Process
    {
        public Login() : base("login", ProcessType.Program)
        {
            Console.WriteLine("Push OS ver 0.1");
            Console.WriteLine();
            Console.Write("login: ");
            var username = Console.ReadLine();
            Console.WriteLine("password: ");
            var password = Console.ReadLine();
        }
    }
}
