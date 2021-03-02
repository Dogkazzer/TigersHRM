using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tiger.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, Name = "Ghana" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, Name = "Netherlands" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, Name = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 5, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 6, Name = "UK" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 7, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 8, Name = "Brazil" });

            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 1, JobCategoryName = "Cake research" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 2, JobCategoryName = "Sales" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 3, JobCategoryName = "Management" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 4, JobCategoryName = "Shop staff" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 5, JobCategoryName = "Finance" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 6, JobCategoryName = "QA" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 7, JobCategoryName = "IT" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 8, JobCategoryName = "Security" });
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory() { JobCategoryId = 9, JobCategoryName = "Bakery" });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                CountryId = 1,
                BirthDate = new DateTime(2000, 4, 27),
                City = "Bath",
                Email = "Cazz@tiger.com",
                FirstName = "Cazz",
                LastName = "Wagg",
                PhoneNumber = "38729102345",
                Smoker = false,
                Street = "Tree Ridge",
                Postcode = "WY3",
                JobCategoryId = 1,
                Comment = "CEO, the boss",
                ExitDate = null,
                JoinedDate = new DateTime(2007, 2, 12),
                Latitude = 50.8503,
                Longitude = 4.3517
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                CountryId = 2,
                BirthDate = new DateTime(2009, 4, 20),
                City = "Hillside",
                Email = "Charlie@tiger.com",
                EmployeeId = 2,
                FirstName = "Charlie",
                LastName = "Wagg",
                PhoneNumber = "28390129374",
                Smoker = false,
                Street = "HillSide",
                Postcode = "WY3",
                JobCategoryId = 1,
                Comment = "Exec baker",
                ExitDate = null,
                JoinedDate = new DateTime(2010, 4, 19),
                Latitude = 50.8503,
                Longitude = 4.3517
            });
           

        }
    }
}   
