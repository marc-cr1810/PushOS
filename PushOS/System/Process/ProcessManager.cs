using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushOS.System.Process
{
    internal class ProcessManager
    {
        private static Dictionary<uint, Process> Processes;
        private static uint NextProcessID;

        public static void Init()
        {
            Processes = new Dictionary<uint, Process>();
            NextProcessID = 0;
        }

        public static void Start(Process process)
        {
            process.SetID(NextProcessID++);
            Processes.Add(process.ID, process);
            process.Start();
        }

        public static void Stop(uint pid)
        {
            if (Processes.ContainsKey(pid))
            {
                Processes[pid].Stop();
                Processes.Remove(pid);
            }
        }

        public static void Update()
        {
            foreach (var (_, Process) in Processes)
            {
                Process.Update();
            }
        }

        public static Process GetProcess(uint pid)
        {
            return Processes[pid];
        }
    }
}
