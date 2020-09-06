using System;

namespace Constructors2
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialised");
            Console.WriteLine(registrationNumber);
        }
    }
}
