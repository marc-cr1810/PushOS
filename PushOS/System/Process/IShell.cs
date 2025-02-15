using PushOS.System.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushOS.System.Process
{
    internal interface IShell
    {
        public User ActiveUser { get; protected set; }
    }
}
