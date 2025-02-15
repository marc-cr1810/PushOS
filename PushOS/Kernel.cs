using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using PushOS.System.Process;
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
        internal CosmosVFS FileSystem { get; private set; }
        internal SysInit Init { get; private set; }

        protected override void BeforeRun()
        {
            Console.WriteLine("Initializing file system");
            FileSystem = new CosmosVFS();
            VFSManager.RegisterVFS(FileSystem);

            Init = new SysInit();

            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            ProcessManager.Update();

            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            Console.WriteLine(input);
        }
    }
}
