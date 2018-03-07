using System;
using System.Collections.Generic;
using System.Text;

namespace Person.DomainClasses
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public DateTime? HireDate { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; } 
    }
}
