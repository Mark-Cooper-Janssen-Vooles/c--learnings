using HelloWorld2.Math;
using System;
using System.Runtime.CompilerServices;

namespace HelloWorld2
{
    public class Person
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number); // number will be 1, since it is a value type

            var person = new Person();
            person.Age = 10;
            MakeOld(person);
            Console.WriteLine(person.Age); //age will be 20, since it is a reference type and needs to be made using the new keyword
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
