using System;
using System.Collections.Generic;
using System.Text;

namespace Person.DomainClasses
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }

    }
}
