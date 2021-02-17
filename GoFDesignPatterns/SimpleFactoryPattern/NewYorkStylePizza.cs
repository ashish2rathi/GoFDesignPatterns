using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryPattern
{
    class NewYorkStylePizza : IPizza
    {
        public int price()
        {
            return 150;
        }
    }
}