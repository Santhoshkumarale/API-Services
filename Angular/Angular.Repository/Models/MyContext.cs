using Angular.Repository.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angular.Repository.Models
{
    public class MyContext: rardbContext
    {
        public MyContext()
        {
        }

        public MyContext(DbContextOptions<rardbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEmp>(entity => entity.HasNoKey());
            base.OnModelCreating(modelBuilder);
        }
    }
}
