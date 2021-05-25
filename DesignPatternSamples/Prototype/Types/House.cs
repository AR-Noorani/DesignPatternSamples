using System;

namespace Prototype
{
    public class House : ICloneable
    {
        public int ID { get; set; }
        public string Owner { get; set; }
        public Address Address { get; set; }

        public object Clone()
        {
            var clone = (House)MemberwiseClone();
            clone.Address = (Address)Address.Clone();
            return clone;
        }

        public override string ToString()
        {
            return $"ID = {ID}; Owner = {Owner}; Address = {Address.PostalCode}, {Address.Street} {Address.Province}";
        }
    }
}
