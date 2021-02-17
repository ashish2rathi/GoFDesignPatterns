using System;

namespace PrototypePattern
{
    public abstract class Employee
    {
        public abstract Employee Clone();

        public string Name { get; set; }
        public string Role { get; set; }
    }

    public class Developer : Employee
    {
        public string PreferredLanguage { get; set; }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }
    }

    public class Tester : Employee
    {
        public string PreferredTechnology { get; set; }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }
    }
}
