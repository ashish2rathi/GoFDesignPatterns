using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    //Adapter Class
    public class HondaBike : Bike
    {
        public override Engine EngineDetails()
        {
            var bikeDetails = new BikeDetails();
            return bikeDetails.EngineDetails(2);
        }
    }
}
