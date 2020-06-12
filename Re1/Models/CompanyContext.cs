namespace Re1.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CompanyContext : DbContext
    {
        public CompanyContext()
            : base("name=CompanyContext")
        {
        }
        public virtual DbSet<Employee> Employees { get; set; }
    }

}