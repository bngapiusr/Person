using System;
using System.Collections.Generic;
using System.Text;

namespace Person.DomainClasses
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }


    }
}
