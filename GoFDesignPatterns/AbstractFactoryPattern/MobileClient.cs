using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    //Client
    public class MobileClient
    {
        private readonly ISmartPhone _smartPhone;
        private readonly INormalPhone _normalPhone;

        public MobileClient(IMobilePhone factory)
        {
            _smartPhone = factory.GetSmartPhone();
            _normalPhone = factory.GetNormalPhone();
        }

        public RAMTypes GetSmartPhoneRAMDetails()
        {
            return _smartPhone.GetRAMDetails();
        }

        public RAMTypes GetNormalPhoneRAMDetails()
        {
            return _normalPhone.GetRAMDetails();
        }

    }
}
