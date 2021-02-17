using System;

namespace AdapterPattern
{
    //Target Class
    public class Bike
    {
        public virtual Engine EngineDetails()
        {
            var bikeDetails = new BikeDetails();
            return bikeDetails.EngineDetails();
        }
    }
}
