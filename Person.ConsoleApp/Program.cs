using System;
using System.Linq;
using PersonDemo.Data;
using PersonDemo.DomainClasses;

namespace PersonDemo.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var context = new PersonDbContext())
            {
                AddData();
                // AddExtraAuthorOk();

                var people = context.PersonInfo.ToList();

                //var book = context.Books.Include(p => p.AuthorLink)
                //    .Single(p => p.Title == "Java 2 ME(Micro Edition) is the client.");

                Console.WriteLine("getting a list of authors");
                foreach (var person in people)
                {
                    Console.WriteLine("The Author Name is: " + person.FirstName + "," + person.LastName + ".");
                }

                // pause the screen
                Console.ReadLine();
            }
        }

        private static void AddData()
        {
            using (var contx = new PersonDbContext())
            {

                var p = new PersonInfo
                {
                    FirstName = "Mike",
                    MiddleName = "J",
                    LastName = "Laurance",
                    Email = "mjlaurance@hotmail.com"
                };
                var c = new Customer
                {
                    CompanyName = "Microsoft",
                    ContactTitle = "Manager",
                    //PersonInfoId = p.PersonInfoId //don't use the ids
                    PersonInfo = p

                };

                var e = new Employee
                {
                    HireDate = DateTime.UtcNow,
                    Title = "Business Analyst",
                    //PersonInfoId = p.PersonInfoId //don't use the ids
                    PersonInfo = p

                };
                //Save data
                contx.PersonInfo.Add(p);
                contx.Customer.Add(c);
                contx.Employee.Add(e);
                contx.SaveChanges();
            }

        }
    }

}
