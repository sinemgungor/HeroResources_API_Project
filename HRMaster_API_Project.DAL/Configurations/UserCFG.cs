using HRMaster_API_Project.Entities.Concrete;
using HRMaster_API_Project.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Configurations
{
    public class UserCFG : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.PicturePath).HasColumnType("varchar").HasMaxLength(300);

            User admin1 = new User
            {
                Id=1,
                Name = "Onur",
                Surname = "Akpınar",
                UserName = "onurakpinarr95@gmail.com",
                NormalizedUserName = "ONURAKPINARR95@GMAIL.COM",
                Email = "onurakpinarr95@gmail.com",
                NormalizedEmail = "ONURAKPINARR95@GMAIL.COM",
                PhoneNumber = "+905555555555",
                Address="Üsküdar",
                Status = Status.Active,
                Gender = Gender.Male,
                MarialStatus = MarialStatus.Single,
                BloodGroup = BloodGroup.BPositive,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1986, 3, 15),
                BirthState = "Bolu",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "56789012345",
                HireDate = new DateOnly(2019, 11, 1),
                Job = "ADMIN",
                Salary = 8700.50,
                Title = "Project Manager",
            };

            PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
            admin1.PasswordHash = passwordHasher.HashPassword(admin1, "onurAdmin123");

            builder.HasData(admin1);

            User admin2 = new User
            {
                Id = 2,
                Name = "Sinem",
                Surname = "Güngör",
                UserName = "sinemgngr@outlook.com",
                NormalizedUserName = "SINEMGNGR@OUTLOOK.COM",
                Email = "sinemgngr@outlook.com",
                NormalizedEmail = "SINEMGNGR@OUTLOOK.COM",
                PhoneNumber = "+90544444444",
                Address = "Küçükyalı",
                Status = Status.Active,
                Gender = Gender.Female,
                MarialStatus = MarialStatus.Single,
                BloodGroup = BloodGroup.APositive,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1985, 6, 20),
                BirthState = "Gaziantep",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "57890123456",
                HireDate = new DateOnly(2020, 7, 15),
                Job = "ADMIN",
                Salary = 7900.00,
                Title = "Business Analyst",
            };

            admin2.PasswordHash = passwordHasher.HashPassword(admin2, "sinemAdmin123");

            builder.HasData(admin2);

            User admin3 = new User
            {
                Id = 3,
                Name = "Recep",
                Surname = "Öztuna",
                UserName = "recepoztuna@hotmail.com",
                NormalizedUserName = "RECEPOZTUNA@HOTMAIL.COM",
                Email = "recepoztuna@hotmail.com",
                NormalizedEmail = "RECEPOZTUNA@HOTMAIL.COM",
                PhoneNumber = "+905333333333",
                Address = "Edirne",
                Status = Status.Active,
                Gender = Gender.Male,
                MarialStatus = MarialStatus.Single,
                BloodGroup = BloodGroup.OPositive,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1992, 10, 5),
                BirthState = "Mardin",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "58901234567",
                HireDate = new DateOnly(2021, 3, 1),
                Job = "ADMINt",
                Salary = 7300.25,
                Title = "Digital Marketing Specialist",
            };

            admin3.PasswordHash = passwordHasher.HashPassword(admin3, "recepAdmin123");

            builder.HasData(admin3);

            User admin4 = new User
            {
                Id = 4,
                Name = "Cemre",
                Surname = "Admin",
                UserName = "ozercemre1@gmail.com",
                NormalizedUserName = "OZERCEMRE1@GMAIL.COM",
                Email = "ozercemre1@gmail.com",
                NormalizedEmail = "OZERCEMRE1@GMAIL.COM",
                PhoneNumber = "+905311111111",
                Address = "Zeytinburnu",
                Status = Status.Active,
                Gender = Gender.Male,
                MarialStatus = MarialStatus.Single,
                BloodGroup = BloodGroup.ABPositive,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1992, 10, 5),
                BirthState = "Mardin",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "58901234567",
                HireDate = new DateOnly(2021, 3, 1),
                Job = "ADMIN",
                Salary = 7300.25,
                Title = "Digital Marketing Specialist",
            };

            admin4.PasswordHash = passwordHasher.HashPassword(admin4, "cemreAdmin123");

            builder.HasData(admin4);

            var manager1 = new User
            {
                Id = 5,
                Name = "Ali",
                Surname = "Yılmaz",
                UserName = "ali.yilmaz@example.com",
                NormalizedUserName = "ALI.YILMAZ@EXAMPLE.COM",
                Email = "ali.yilmaz@example.com",
                NormalizedEmail = "ALI.YILMAZ@EXAMPLE.COM",
                PhoneNumber = "+905311234567",
                Address = "Kadıköy",
                Status = Status.Active,
                Gender = Gender.Male,
                MarialStatus = MarialStatus.Single,
                BloodGroup = BloodGroup.APositive,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1992, 11, 10),
                BirthState = "Bursa",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "43212345312",
                HireDate = new DateOnly(2020, 10, 1),
                Job = "CEO",
                Salary = 8700.25,
                Title = "HR Manager",
                CEORelatedCompanyID=1
            };
            manager1.PasswordHash = passwordHasher.HashPassword(manager1, "Manager123");
            builder.HasData(manager1);

            var manager2 = new User
            {
                Id = 6,
                Name = "Ayşe",
                Surname = "Demir",
                UserName = "ayse.demir@example.com",
                NormalizedUserName = "AYSE.DEMIR@EXAMPLE.COM",
                Email = "ayse.demir@example.com",
                NormalizedEmail = "AYSE.DEMIR@EXAMPLE.COM",
                PhoneNumber = "+905322345678",
                Address = "Beşiktaş",
                Status = Status.Active,
                Gender = Gender.Female,
                MarialStatus = MarialStatus.Married,
                BloodGroup = BloodGroup.BNegative,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1985, 5, 20),
                BirthState = "İstanbul",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "53245678901",
                HireDate = new DateOnly(2018, 6, 15),
                Job = "CEO",
                Salary = 9200.75,
                Title = "Chief Technology Officer",
                CEORelatedCompanyID = 2
            };
            manager2.PasswordHash = passwordHasher.HashPassword(manager2, "Manager123");
            builder.HasData(manager2);

            var manager3 = new User
            {
                Id = 7,
                Name = "Mehmet",
                Surname = "Kaya",
                UserName = "mehmet.kaya@example.com",
                NormalizedUserName = "MEHMET.KAYA@EXAMPLE.COM",
                Email = "mehmet.kaya@example.com",
                NormalizedEmail = "MEHMET.KAYA@EXAMPLE.COM",
                PhoneNumber = "+905336789012",
                Address = "Üsküdar",
                Status = Status.Active,
                Gender = Gender.Male,
                MarialStatus = MarialStatus.Single,
                BloodGroup = BloodGroup.ANegative,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1978, 8, 30),
                BirthState = "Ankara",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "32145698700",
                HireDate = new DateOnly(2016, 2, 10),
                Job = "CFO",
                Salary = 9500.50,
                Title = "Chief Financial Officer",
                CEORelatedCompanyID = 3
            };
            manager3.PasswordHash = passwordHasher.HashPassword(manager3, "Manager123");
            builder.HasData(manager3);

            var manager4 = new User
            {
                Id = 8,
                Name = "Fatma",
                Surname = "Yurt",
                UserName = "fatma.yurt@example.com",
                NormalizedUserName = "FATMA.YURT@EXAMPLE.COM",
                Email = "fatma.yurt@example.com",
                NormalizedEmail = "FATMA.YURT@EXAMPLE.COM",
                PhoneNumber = "+905349876543",
                Address = "Taksim",
                Status = Status.Active,
                Gender = Gender.Female,
                MarialStatus = MarialStatus.Married,
                BloodGroup = BloodGroup.ONegative,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1990, 12, 5),
                BirthState = "İzmir",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "45678901234",
                HireDate = new DateOnly(2019, 11, 22),
                Job = "COO",
                Salary = 8800.00,
                Title = "Chief Operating Officer",
                CEORelatedCompanyID = 4
            };
            manager4.PasswordHash = passwordHasher.HashPassword(manager4, "Manager123");
            builder.HasData(manager4);

            var employee1 = new User
            {
                Id = 9,
                Name = "Mert",
                Surname = "Kaya",
                UserName = "mert.kaya@example.com",
                NormalizedUserName = "MERT.KAYA@EXAMPLE.COM",
                Email = "mert.kaya@example.com",
                NormalizedEmail = "MERT.KAYA@EXAMPLE.COM",
                PhoneNumber = "+905341234567",
                Address = "Kadıköy",
                Status = Status.Active,
                Gender = Gender.Male,
                MarialStatus = MarialStatus.Single,
                BloodGroup = BloodGroup.ABPositive,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1990, 9, 15),
                BirthState = "Ankara",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "78901234567",
                HireDate = new DateOnly(2021, 4, 10),
                Job = "Software Developer",
                Salary = 7500.50,
                Title = "Junior Developer",
                EmployeeRelatedCompanyID = 3
            };

            employee1.PasswordHash = passwordHasher.HashPassword(employee1, "Employee123");
            builder.HasData(employee1);

            var employee2 = new User
            {
                Id = 10,
                Name = "Elif",
                Surname = "Koç",
                UserName = "elif.koc@example.com",
                NormalizedUserName = "ELIF.KOC@EXAMPLE.COM",
                Email = "elif.koc@example.com",
                NormalizedEmail = "ELIF.KOC@EXAMPLE.COM",
                PhoneNumber = "+905355678901",
                Address = "Etiler",
                Status = Status.Active,
                Gender = Gender.Female,
                MarialStatus = MarialStatus.Single,
                BloodGroup = BloodGroup.OPositive,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1993, 2, 18),
                BirthState = "İzmir",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "12365478901",
                HireDate = new DateOnly(2019, 1, 20),
                Job = "Project Manager",
                Salary = 8000.75,
                Title = "Manager",
                EmployeeRelatedCompanyID = 3
            };

            employee2.PasswordHash = passwordHasher.HashPassword(employee2, "Employee123");
            builder.HasData(employee2);

            var employee3 = new User
            {
                Id = 11,
                Name = "Ahmet",
                Surname = "Öztürk",
                UserName = "ahmet.ozturk@example.com",
                NormalizedUserName = "AHMET.OZTURK@EXAMPLE.COM",
                Email = "ahmet.ozturk@example.com",
                NormalizedEmail = "AHMET.OZTURK@EXAMPLE.COM",
                PhoneNumber = "+905399876543",
                Address = "Bakırköy",
                Status = Status.Active,
                Gender = Gender.Male,
                MarialStatus = MarialStatus.Married,
                BloodGroup = BloodGroup.ANegative,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1988, 12, 30),
                BirthState = "Antalya",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "98765432109",
                HireDate = new DateOnly(2020, 5, 5),
                Job = "Data Analyst",
                Salary = 7200.00,
                Title = "Analyst",
                EmployeeRelatedCompanyID = 3
            };

            employee3.PasswordHash = passwordHasher.HashPassword(employee3, "Employee123");
            builder.HasData(employee3);

            var employee4 = new User
            {
                Id = 12,
                Name = "Zeynep",
                Surname = "Arslan",
                UserName = "zeynep.arslan@example.com",
                NormalizedUserName = "ZEYNEP.ARSLAN@EXAMPLE.COM",
                Email = "zeynep.arslan@example.com",
                NormalizedEmail = "ZEYNEP.ARSLAN@EXAMPLE.COM",
                PhoneNumber = "+905366543210",
                Address = "Beylikdüzü",
                Status = Status.Active,
                Gender = Gender.Female,
                MarialStatus = MarialStatus.Single,
                BloodGroup = BloodGroup.BPositive,
                CreationDate = DateTime.UtcNow,
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                BirthDate = new DateOnly(1995, 7, 10),
                BirthState = "Adana",
                PicturePath = "default-avatar.jpg",
                IdentityNumber = "67890123456",
                HireDate = new DateOnly(2022, 3, 1),
                Job = "Marketing Specialist",
                Salary = 6800.30,
                Title = "Specialist",
                EmployeeRelatedCompanyID = 3
            };

            employee4.PasswordHash = passwordHasher.HashPassword(employee4, "Employee123");
            builder.HasData(employee4);

            builder.HasOne(u => u.EmployeeRelatedCompany)
               .WithMany(c => c.Employees)
               .HasForeignKey(u => u.EmployeeRelatedCompanyID)
               .OnDelete(DeleteBehavior.Restrict);

            // Bire bir ilişki: Bir şirketin sadece bir CEO'su olabilir
            builder.HasOne(u => u.CEORelatedCompany)
                   .WithOne(c => c.CEO)
                   .HasForeignKey<Company>(c => c.CEOId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(u => u.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(u => u.DepartmentID)
                .OnDelete(DeleteBehavior.SetNull);


            builder.Property(u => u.Name)
           .HasMaxLength(100);

            // SecondName
            builder.Property(u => u.SecondName)
                .HasMaxLength(100);

            // Surname
            builder.Property(u => u.Surname)
                .HasMaxLength(100);

            // SecondSurname
            builder.Property(u => u.SecondSurname)
                .HasMaxLength(100);

            // PicturePath
            builder.Property(u => u.PicturePath)
                .HasMaxLength(500);

            // BirthDate
            builder.Property(u => u.BirthDate)
                .HasColumnType("date");

            // BirthState
            builder.Property(u => u.BirthState)
                .HasMaxLength(50);

            // IdentityNumber
            builder.Property(u => u.IdentityNumber)
                .HasMaxLength(20);

            // HireDate
            builder.Property(u => u.HireDate)
                .HasColumnType("date");

            // TerminationDate
            builder.Property(u => u.TerminationDate)
                .HasColumnType("date");

            // Job
            builder.Property(u => u.Job)
                .HasMaxLength(100);

            // Address
            builder.Property(u => u.Address)
                .HasMaxLength(250);

            // Salary
            builder.Property(u => u.Salary)
                .HasColumnType("decimal(18,2)");

            builder.Property(u => u.BloodGroup)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Property(u => u.MarialStatus)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Property(u => u.Gender)
                .HasConversion<string>()
                .HasMaxLength(20);
        }
    }
}
