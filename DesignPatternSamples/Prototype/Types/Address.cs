using System;

namespace Prototype
{
    public class Address : ICloneable
    {
        public string Province { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
