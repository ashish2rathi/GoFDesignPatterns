using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    //Adapter Class
    public class BajajBike : Bike
    {
        public override Engine EngineDetails()
        {
            var bikeDetails = new BikeDetails();
            return bikeDetails.EngineDetails(1);
        }
    }
}
