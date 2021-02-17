using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    class NeapolitanPizza : IPizza
    {
        public int price()
        {
            return 100;
        }
    }
}
