using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonDemo.DomainClasses;

namespace PersonDemo.Web.Models
{
    public class MockPersonRepository : IPeopleRepository
    {
        private List<PersonInfo> _person;

        public MockPersonRepository()
        {
            if (_person==null)
            {
                InitializePerson();
            }
        }

        private void InitializePerson()
        {
            _person = new List<PersonInfo>
            {
                new PersonInfo
                {
                    PersonInfoId = 1,
                    FirstName = "Mike",
                    MiddleName = "J",
                    LastName = "Laurance",
                    Email = "mjlaurance@hotmail.com"
                },
                new PersonInfo
                {
                    PersonInfoId = 2,
                    FirstName = "John",
                    MiddleName = "R",
                    LastName = "Smith",
                    Email = "jdsmith@aol.com"
                }
            };
        }

        public IEnumerable<PersonInfo> GetAllPerson()
        {
            return _person;
        }

        public PersonInfo GetPersonInfoById(int personInfoId)
        {
            return _person.FirstOrDefault(p => p.PersonInfoId == personInfoId);
        }
    }
}
