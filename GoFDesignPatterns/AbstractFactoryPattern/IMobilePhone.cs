using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //Abstract Factory
    public interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }

    //Concrete Factory
    public class RedmiFactory : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new RedmiNote5();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Redmi2S();
        }
    }

    public class SamsungFactory : IMobilePhone
    {
        public ISmartPhone GetSmartPhone()
        {
            return new SamsungGalaxy();
        }

        public INormalPhone GetNormalPhone()
        {
            return new Samsung100();
        }
    }
}
