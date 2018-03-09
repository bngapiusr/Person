using Microsoft.EntityFrameworkCore;
using PersonDemo.DomainClasses;
//using Person = Person.DomainClasses.Person;

namespace PersonDemo.Data
{
    public class PeopleDbContext : DbContext
    {

        //Use for consoleapp
        private const string ConnectionString = @"Server=.\;
                                                  Database=Person;
                                                  Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<PersonInfo> PersonInfo { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonInfo>()
                .HasOne(p => p.Customer)
                .WithOne(c => c.PersonInfo)
                .HasForeignKey<Customer>(c => c.PersonInfoId);

            modelBuilder.Entity<PersonInfo>()
                .HasOne(p => p.Employee)
                .WithOne(e => e.PersonInfo)
                .HasForeignKey<Employee>(e => e.PersonInfoId);

            //modelBuilder.Entity<DomainClasses.Person>()
            //    .HasOne(p => p.Customer)
            //    .WithOne(c => c.Person)
            //    .HasForeignKey<Customer>(c => c.PersonId);
        }

    }
}
