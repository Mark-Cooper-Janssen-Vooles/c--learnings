using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime birthDate)
        {
            this._birthDate = birthDate;
        }

        public DateTime GetBirthDate()
        {
            return _birthDate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            // person._birthDate // this will not work! to set the birthDate you need a method.
            person.SetBirthDate(new DateTime(2020, 1, 1));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
