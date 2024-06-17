using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.DB
{
    public class MyContext : DbContext
    {
        private string cs = "server =CABOTIK\\MSSQLSERVERR; database=first; user id=sa; password =sa; Encrypt=False";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }

       public DbSet<User> users { get; set; }
        public DbSet<Request> requests { get; set; }
        public DbSet<Department> department { get; set; }
    }
}
