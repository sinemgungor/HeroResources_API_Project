using HRMaster_API_Project.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace HRMaster_API_Project.DAL.Context
{
    public class AppDbContext: IdentityDbContext<User, Role, int>
    {
        public AppDbContext()
        {
            
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<AdvanceRequest> AdvanceRequests { get; set; }
        public DbSet<ExpenseRequest> ExpenseRequests { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data source=.; Initial catalog =hr_hero_db;Integrated security=true;TrustServerCertificate=true;");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 1, RoleId = 1 });
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 2, RoleId = 1 });
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 3, RoleId = 1 });
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 4, RoleId = 1 }); 
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 5, RoleId = 2 });
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 6, RoleId = 2 });
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 7, RoleId = 2 });
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 8, RoleId = 2 });
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 9, RoleId = 3});
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 10, RoleId = 3});
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 11, RoleId = 3});
            builder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>() { UserId = 12, RoleId = 3});


        }
    }
}
