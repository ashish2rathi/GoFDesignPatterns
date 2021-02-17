using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    //Adaptee class
    class BikeDetails
    {
        public Engine EngineDetails(int engineID = 0)
        {
            switch (engineID)
            {
                case 1:
                    return new Engine(engineID, "DTS-SI");
                case 2:
                    return new Engine(engineID, "Gear Engine");
                default:
                    return new Engine(engineID, "Normal Engine");
            }
        }
    }
}
