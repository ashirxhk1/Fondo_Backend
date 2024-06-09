using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace BulkyBookWeb.Data
{
    public class DataBaseContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

      
    }
}
