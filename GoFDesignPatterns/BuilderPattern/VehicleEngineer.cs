using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class VehicleEngineer
    {
        private readonly IVehicleBuilder objBuilder;

        public VehicleEngineer(IVehicleBuilder builder)
        {
            objBuilder = builder;
        }

        public void CreateVehicle()
        {
            objBuilder.SetModel();
            objBuilder.SetEngine();
            objBuilder.SetBody();
            objBuilder.SetTransmission();
        }

        public Vehicle GetVehicle()
        {
            return objBuilder.GetVehicle();
        }
    }
}
