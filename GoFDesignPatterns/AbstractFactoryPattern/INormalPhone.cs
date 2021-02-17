using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //Abstract Product
    public interface INormalPhone
    {
        RAMTypes GetRAMDetails();
    }


    //Concrete Products
    class Redmi2S : INormalPhone
    {
        public RAMTypes GetRAMDetails()
        {
            return RAMTypes.OneGB;
        }
    }

    class Samsung100 : INormalPhone
    {
        public RAMTypes GetRAMDetails()
        {
            return RAMTypes.NA;
        }
    }

}
