using System;
using System.Text.RegularExpressions;

namespace DomainPrimitives {

public class LastName {

    private string lastName;

// Constructor

        public LastName(string lastName)
        {
            IsLastNameValid(lastName);
            this.lastName = lastName;
        }

// Validate last name input
        private void IsLastNameValid(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentException("Invalid last name");
            }
            else if (lastName.Length < 2 || lastName.Length > 20)
            {
                throw new ArgumentException("Last name must be between 2 and 20 characters");
            }
            else if (!Regex.IsMatch(lastName, @"^[a-zA-ZæøåÆØÅ]+$"))
            {
                throw new ArgumentException("Last name can only contain letters");
            }
        }

// Get last name method
        public string GetLastName()
        {
            return lastName;
        }
}





}