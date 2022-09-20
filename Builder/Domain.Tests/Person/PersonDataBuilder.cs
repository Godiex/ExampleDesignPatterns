using System;
using Domain.Entities;

namespace Domain.Tests.Person
{
    public class PersonDataBuilder
    {
        private string _firstName = default!;
        private string _lastName = default!;
        private string _email = default!;
        private DateTime _dateOfBirth;

        public Domain.Entities.Person Build()
        {
            Domain.Entities.Person person = new(_firstName, _lastName, _email, _dateOfBirth);           
            return person;
        }

        public PersonDataBuilder WithDateOfBirth(DateTime dateOfBirth)
        {
            _dateOfBirth = dateOfBirth;
            return this;
        } 

        public PersonDataBuilder WithName(string name)
        {
            _firstName = name;
            return this;
        }

        public PersonDataBuilder WithLastName(string last)
        {
            _lastName = last;
            return this;
        }

        public PersonDataBuilder WithEmail(string email)
        {
            _email = email;
            return this;
        }
    }
}
