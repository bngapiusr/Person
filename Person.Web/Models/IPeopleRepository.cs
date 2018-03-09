using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonDemo.DomainClasses;

namespace PersonDemo.Web.Models
{
    public interface IPeopleRepository
    {
        IEnumerable<PersonInfo> GetAllPerson();
        PersonInfo GetPersonInfoById(int personInfoId);
    }
}
