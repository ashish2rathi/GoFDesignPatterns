using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class BajajBuilder : IVehicleBuilder
    {
        private Vehicle _pulsar = new Vehicle();

        public void SetModel()
        {
            _pulsar.Model = "Pulsar150";
        }

        public void SetEngine()
        {
            _pulsar.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            _pulsar.Transmission = "120 km/hr";
        }

        public void SetBody()
        {
            _pulsar.Body = "Black Red";
        }

        public Vehicle GetVehicle()
        {
            return _pulsar;
        }
    }
}
