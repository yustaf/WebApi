using System.Data.Entity;

namespace WebApi1.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> user {get;set;}
    }
}