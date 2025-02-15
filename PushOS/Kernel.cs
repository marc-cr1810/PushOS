using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using PushOSs.System.Init;
using PushOSs.System.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace PushOSs
{
    public class Kernel : Sys.Kernel
    {
        CosmosVFS FileSystem;

        protected override void BeforeRun()
        {
            FileSystem = new CosmosVFS();
            VFSManager.RegisterVFS(FileSystem);

            SysInit sysinit = new SysInit();

            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
