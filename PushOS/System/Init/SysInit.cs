using PushOS.System.Process;
using PushOS.System.Users;
using PushOSs.System.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushOSs.System.Init
{
    internal class SysInit
    {
        public SysInit()
        {
            SysPrint.Ok("Initializing Process Manager");
            ProcessManager.Init();

            SysPrint.Ok("Loading system users");
            Users.LoadUsers();
        }
    }
}
