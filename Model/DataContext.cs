using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentApis.Model
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<StudentDetails> student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDetails>().HasData(new { Id = 1, StudentName = "prasanna", RollNumber = "prasanna1", StudentClass = 5,section="A" });
            modelBuilder.Entity<StudentDetails>().HasData(new { Id = 2, StudentName = "Ace", RollNumber = "Ace2", StudentClass = 5 });
            modelBuilder.Entity<StudentDetails>().HasData(new { Id = 3, StudentName = "Yuno", RollNumber = "Yuno3", StudentClass = 5 });

            modelBuilder.Entity<StudentDetails>()
                .Property(p => p.section)
                .IsRequired(true)
                .HasDefaultValue("NA");

            base.OnModelCreating(modelBuilder);


        }
    }
}


