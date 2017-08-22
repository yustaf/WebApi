using System.Data.Entity;

namespace WebApi2.Models
{
    public class DepartmentContext : DbContext
    {
        public DbSet<Department> department {get;set;}
    }
}