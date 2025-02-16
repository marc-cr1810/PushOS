//using PushOS.Parser.Ini;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PushOS.System.Init
{


    internal struct ServiceConfig
    {
        internal struct UnitConfig
        {
            public string Description;
        }

        internal struct ServiceConf
        {
            public string User;
            public string ExecStart;
        }

        UnitConfig Unit;
        ServiceConf Service;
    }

    internal class Service
    {
        public ServiceConfig Config { get; init; }

        public Service(string file)
        {
            //Config = IniFile.ToObject<ServiceConfig>(file);
        }

        public void Start()
        {

        }

        public void Stop()
        {

        }

        public void Restart()
        {

        }
    }
}
