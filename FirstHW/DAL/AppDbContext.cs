using FirstHW.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstHW.DAL
{
    internal class AppDbContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-MQ9MD48\\SQLEXPRESS01; Database = summerPrep; Encrypt = False; Trusted_Connection = True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

    }


}
