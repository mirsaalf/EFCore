using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Database = Name of database
            // Server = Server we are connecting to, LocalDb is included with VS
            // Trusted_Connection indicateds that our windows account will be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }

        // Tell EF Core to track Students in the database
        public DbSet<Student> Students { get; set; }
    }
}
