using System;

namespace Prototype
{
    class Program
    {
        static void Main()
        {
            var house = new House
            {
                ID = 1,
                Owner = "Mr. Names",
                Address = new Address
                {
                    Province = "Tehran",
                    Street = "SomeWhere St.",
                    PostalCode = "12345"
                }
            };

            Console.WriteLine(house);

            var otherHouse = (House)house.Clone();
            otherHouse.ID = 2;
            otherHouse.Address.PostalCode = "12346";

            Console.WriteLine(otherHouse);

            Console.ReadKey();
        }
    }
}
