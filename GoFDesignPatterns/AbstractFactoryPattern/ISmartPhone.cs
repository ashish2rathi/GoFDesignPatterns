using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //Abstract Product
    public interface ISmartPhone
    {
        RAMTypes GetRAMDetails();
    }

    //Concrete Products
    class RedmiNote5 : ISmartPhone
    {
        public RAMTypes GetRAMDetails()
        {
            return RAMTypes.TwoGB;
        }
    }

    class SamsungGalaxy : ISmartPhone
    {
        public RAMTypes GetRAMDetails()
        {
            return RAMTypes.ThreeGB;
        }
    }
}
