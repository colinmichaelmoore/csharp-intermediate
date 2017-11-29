using System;

namespace section2_11
{
    class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)

        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }

    }
}