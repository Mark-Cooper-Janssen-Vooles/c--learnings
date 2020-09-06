using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime BirthDate { get; private set; } //to set this only once, set to private. Need to then set via constructor
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

        public Person(DateTime birthDate)
        {
            this.BirthDate = birthDate;
        }
    }
}
