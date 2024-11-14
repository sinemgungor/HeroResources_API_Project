using HRMaster_API_Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Configurations
{
    public class ExpenseRequestCFG : IEntityTypeConfiguration<ExpenseRequest>
    {
        public void Configure(EntityTypeBuilder<ExpenseRequest> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(er => er.ExpenseType)
           .HasConversion<int>() // Converts the enum to an int for storage
           .IsRequired();

            // Amount - Required field
            builder.Property(er => er.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            // Currency - Enum field as int
            builder.Property(er => er.Currency)
                .HasConversion<int>() // Converts the enum to an int for storage
                .IsRequired();

            // ApprovalStatus - Enum field as int
            builder.Property(er => er.ApprovalStatus)
                .HasConversion<int>() // Converts the enum to an int for storage
                .IsRequired();

            // RequestDate - Required field
            builder.Property(er => er.RequestDate)
                .IsRequired();

            // ResponseDate - Optional field
            builder.Property(er => er.ResponseDate)
                .IsRequired(false);

            // FilePath - Optional field with a max length
            builder.Property(er => er.FilePath)
                .HasMaxLength(500) // Set this length as appropriate
                .IsRequired(false);

            // EmployeeID - Foreign Key relation with User
            builder.HasOne(er => er.Employee)
                .WithMany(u => u.ExpenseRequests)
                .HasForeignKey(er => er.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
