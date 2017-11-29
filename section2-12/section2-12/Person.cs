using System;

namespace section2_12
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthday)
        {
            Birthdate = Birthdate;
        }
        

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }

        }
    }
}