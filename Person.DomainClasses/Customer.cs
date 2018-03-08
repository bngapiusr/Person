using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemo.DomainClasses
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public int PersonInfoId { get; set; }
        public PersonInfo PersonInfo { get; set; }

    }
}
