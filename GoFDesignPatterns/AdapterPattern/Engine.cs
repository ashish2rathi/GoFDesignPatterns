using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AdapterPattern
{
    public class Engine
    {
        public Engine(int engineID, string engineName)
        {
            EngineID = engineID;
            EngineName = engineName;
        }
        public int EngineID { get; }

        public string EngineName { get; }

    }
}
