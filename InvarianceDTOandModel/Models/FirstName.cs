using System;
using System.Text.RegularExpressions;

namespace DomainPrimitives {

public class FirstName {

    private string firstName;

// Constructor
        public FirstName(string firstName)
        {
            IsFirstNameValid(firstName);
            this.firstName = firstName;
        }

// Validate first name input
        private void IsFirstNameValid(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Invalid first name");
            }
            else if (firstName.Length < 2 || firstName.Length > 20)
            {
                throw new ArgumentException("First name must be between 2 and 20 characters");
            }
            else if (!Regex.IsMatch(firstName, @"^[a-zA-ZæøåÆØÅ]+$"))
            {
                throw new ArgumentException("First name can only contain letters");
            }
        }


// Get first name method
        public string GetFirstName()
        {
            return firstName;
        }
}





}