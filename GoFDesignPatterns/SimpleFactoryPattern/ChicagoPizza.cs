using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    class ChicagoPizza : IPizza
    {
        public int price()
        {
            return 120;
        }
    }
}