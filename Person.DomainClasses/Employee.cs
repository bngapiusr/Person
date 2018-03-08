using System;
using System.Collections.Generic;
using System.Text;

namespace PersonDemo.DomainClasses
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public DateTime? HireDate { get; set; }
        public int PersonInfoId { get; set; }
        public PersonInfo PersonInfo { get; set; } 
    }
}
