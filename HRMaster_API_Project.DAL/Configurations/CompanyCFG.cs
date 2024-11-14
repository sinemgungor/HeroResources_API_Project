using HRMaster_API_Project.Entities.Concrete;
using HRMaster_API_Project.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Configurations
{
    public class CompanyCFG : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            Company company1 = new Company
            {
                ID = 1,
                CreationDate = DateTime.Now,
                CompanyName = "Tech Innovations",
                CompanyTitle = "Tech Innovations Bilişim ve Teknoloji Şirketi",
                LogoPath = "/images/logos/tech_innovations.png",
                MersisNumber = "1234567890",
                TaxOfficeName = "Downtown Tax Office",
                TaxIdentificaitonNumber = "TI123456",
                CompanyAddress = "123 Innovation Drive",
                CompanyPhoneNumber = "555-1234",
                CompanyEmail = "contact@techinnovations.com",
                CompanyWebsite = "www.techinnovations.com",
                CompanyType = CompanyType.SoleProprietorship,
                CompanyField = CompanyField.Technology,
                EstablishedDate = new DateOnly(2001, 4, 23),
                ContractStartingDate = new DateOnly(2020, 3, 30),
                CompanyInformation = "Leading tech company specializing in innovative solutions.",
                CEOId=5
            };
            builder.HasData(company1);
            Company company2 = new Company
            {
                ID = 2,
                CreationDate = DateTime.Now,
                CompanyName = "Green Energy Solutions",
                CompanyTitle = "Green Energy Solutions AŞ.",
                LogoPath = "/images/logos/greenenergy.jpeg",
                MersisNumber = "0987654321",
                TaxOfficeName = "Uptown Tax Office",
                TaxIdentificaitonNumber = "TI654321",
                CompanyAddress = "456 Green Road",
                CompanyPhoneNumber = "555-5678",
                CompanyEmail = "info@greenenergy.com",
                CompanyWebsite = "www.greenenergy.com",
                CompanyType = CompanyType.JointStockCompany,
                CompanyField = CompanyField.Energy,
                EstablishedDate = new DateOnly(2010, 7, 15),
                ContractStartingDate = new DateOnly(2020, 3, 30),
                CompanyInformation = "Providing renewable energy solutions worldwide.",
                CEOId = 6
            };
            builder.HasData(company2);
            Company company3 = new Company
            {
                ID = 3,
                CreationDate = DateTime.Now,
                CompanyName = "Health & Wellness",
                CompanyTitle = "Health & Wellness Sağlık ve Güzellik Merkezi LTD.ŞTİ.",
                LogoPath = "/images/logos/healthandwellness.jpeg",
                MersisNumber = "1122334455",
                TaxOfficeName = "City Tax Office",
                TaxIdentificaitonNumber = "TI112233",
                CompanyAddress = "789 Wellness Ave",
                CompanyPhoneNumber = "555-7890",
                CompanyEmail = "support@healthwellness.com",
                CompanyWebsite = "www.healthwellness.com",
                CompanyType = CompanyType.LimitedCompany,
                CompanyField = CompanyField.Healthcare,
                EstablishedDate = new DateOnly(2015, 3, 30),
                ContractStartingDate = new DateOnly(2020, 3, 30),
                CompanyInformation = "Committed to providing top health and wellness services.",
                CEOId = 7
            };
            builder.HasData(company3);
            Company company4 = new Company
            {
                ID = 4,
                CreationDate = DateTime.Now,
                CompanyName = "EduFuture Academy",
                CompanyTitle ="EduFuture Eğitim Merkezi LTD.ŞTİ.",
                LogoPath = "/images/logos/edufuture.jpeg",
                MersisNumber = "5566778899",
                TaxOfficeName = "Suburb Tax Office",
                TaxIdentificaitonNumber = "TI556677",
                CompanyAddress = "101 Education Blvd",
                CompanyPhoneNumber = "555-1011",
                CompanyEmail = "admissions@edufuture.com",
                CompanyWebsite = "www.edufuture.com",
                CompanyType = CompanyType.LimitedCompany,
                CompanyField = CompanyField.Education,
                EstablishedDate = new DateOnly(2020, 1, 10),
                ContractStartingDate = new DateOnly(2020, 3, 30),
                CompanyInformation = "Innovative education for the future.",
                CEOId = 8
            };
            builder.HasData(company4);

            builder.HasOne(c => c.CEO)
                .WithOne(u => u.CEORelatedCompany)
                .HasForeignKey<Company>(c => c.CEOId)
                .OnDelete(DeleteBehavior.Restrict);

            // Bire çok ilişki: Bir şirketin birden fazla çalışanı olabilir
            builder.HasMany(c => c.Employees)
                   .WithOne(u => u.EmployeeRelatedCompany)
                   .HasForeignKey(u => u.EmployeeRelatedCompanyID)
                   .OnDelete(DeleteBehavior.Restrict);


            builder.Property(c => c.CompanyName)
                .HasMaxLength(200)
                .IsRequired();
            builder.Property(c => c.CompanyTitle)
                .HasMaxLength(200)
                .IsRequired();


            builder.Property(c => c.LogoPath)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(c => c.MersisNumber)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.TaxOfficeName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.TaxIdentificaitonNumber)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.CompanyAddress)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(c => c.CompanyPhoneNumber)
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(c => c.CompanyEmail)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.CompanyWebsite)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(c => c.CompanyType)
                .HasConversion<string>()
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.CompanyField)
                .HasConversion<string>()
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.EstablishedDate)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(c => c.ContractStartingDate)
                .HasColumnType("date")
                .IsRequired();
            builder.Property(c => c.ContractEndDate)
                .HasColumnType("date");
      

            builder.Property(c => c.CompanyInformation)
                .HasMaxLength(1000)
                .IsRequired();
        }
    }
}
