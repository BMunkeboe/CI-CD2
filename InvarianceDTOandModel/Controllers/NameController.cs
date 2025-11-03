using System;
using Microsoft.AspNetCore.Mvc;
using ValidateTheNameModelBinding.Models;
using ValidateTheNameModelBinding.Util;
using DomainPrimitives;

namespace ValidateTheNameWebApplication.Controllers
{
    public class NameController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", new { nameIsValid = false, showNameEvaluation = false });
        }

        [HttpPost]
        public IActionResult ValidateName(PersonDTO person)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", new {nameIsValid = false, showNameEvaluation = true });
            }

            //DI intentionally omittede here for clarity
            PersonRepository personRepository = new PersonRepository();

            try
            {
                // Construct domain primitives from DTO strings and pass them to Person
                Person personWithInvariance = new Person(new FirstName(person.Firstname), new LastName(person.Lastname));

                personRepository.AddPerson(personWithInvariance);
            }
            catch (ArgumentException ex)
            {
                // Domain primitive validation failed — report back to the view
                ModelState.AddModelError(string.Empty, ex.Message);
                return View("Index", new { nameIsValid = false, showNameEvaluation = true });
            }

            return View("Index", new { nameIsValid = true, showNameEvaluation = true });


        }

    }
}
