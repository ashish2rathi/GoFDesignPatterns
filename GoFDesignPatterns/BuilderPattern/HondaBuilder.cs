using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class HondaBuilder : IVehicleBuilder
    {
        private Vehicle _suzuki = new Vehicle();
        public void SetModel()
        {
            _suzuki.Model = "Suzuki125";
        }

        public void SetEngine()
        {
            _suzuki.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            _suzuki.Transmission = "90 Km/hr";
        }

        public void SetBody()
        {
            _suzuki.Body = "Red";
        }

        public Vehicle GetVehicle()
        {
            return _suzuki;
        }
    }
}
