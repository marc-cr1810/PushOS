using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushOS.System.Process
{
    internal enum ProcessType
    {
        KernelModule,
        SystemService,
        Program
    }

    internal class Process
    {
        public string Name { get; protected set; }
        public uint ID { get; protected set; }
        public ProcessType Type { get; protected set; }
        public bool Initialized { get; protected set; }
        public bool Running { get; private set; }

        private static readonly Dictionary<uint, string> TypeNames = new Dictionary<uint, string>
        {
            { (uint)ProcessType.KernelModule, "KernelModule" },
            { (uint)ProcessType.SystemService, "Service" },
            { (uint)ProcessType.Program, "Program" }
        };

        public Process(string name, ProcessType type)
        {
            Name = name;
            Type = type;
            ID = 0;
            Running = false;
        }

        public virtual void Initialize()
        {
            if (Initialized)
            {
                return;
            }
            Initialized = true;
        }

        public virtual void Start()
        {
            if (Running)
            {
                return;
            }
            Running = true;
        }

        public virtual void Stop()
        {
            if (!Running)
            {
                return;
            }
            Running = false;
        }

        public virtual void Update() { }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetID(uint id)
        {
            ID = id;
        }

        public void SetType(ProcessType type)
        {
            Type = type;
        }

        public static string GetServiceTypeString(ProcessType type)
        {
            if (TypeNames.ContainsKey((uint)type))
            {
                return TypeNames[(uint)type];
            }
            return "Unknown";
        }
    }
}
