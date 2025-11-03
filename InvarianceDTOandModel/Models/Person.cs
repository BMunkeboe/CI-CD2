using System;
using DomainPrimitives;

namespace ValidateTheNameModelBinding.Models
{
    public class Person
    {
        private FirstName _firstName;
        private LastName _lastName;

        public Person(FirstName firstName, LastName lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public string GetFirstName() => _firstName.GetFirstName();
        public string GetLastName() => _lastName.GetLastName();
    }
}
