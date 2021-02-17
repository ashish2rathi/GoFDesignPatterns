using System;

namespace BuilderPattern
{
    public interface IVehicleBuilder
    {
        void SetModel();
        void SetEngine();
        void SetTransmission();
        void SetBody();

        Vehicle GetVehicle();
    }
}
