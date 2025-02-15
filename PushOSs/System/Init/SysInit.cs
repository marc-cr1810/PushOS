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
            SysPrint.Trace("test message");
            SysPrint.Debug("test message");
            SysPrint.Ok("test message");
            SysPrint.Warning("test message");
            SysPrint.Error("test message");
            SysPrint.Fatal("test message");
        }
    }
}
