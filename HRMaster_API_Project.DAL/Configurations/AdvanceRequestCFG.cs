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
    public class AdvanceRequestCFG : IEntityTypeConfiguration<AdvanceRequest>
    {
        public void Configure(EntityTypeBuilder<AdvanceRequest> builder)
        {
            builder.HasKey(x => x.ID);

            // RequestDate - Required field
            builder.Property(ar => ar.RequestDate)
                .IsRequired();

            // ApprovalStatus - Required field
            builder.Property(ar => ar.ApprovalStatus)
                .IsRequired();

            // ResponseDate - Optional field
            builder.Property(ar => ar.ResponseDate)
                .IsRequired(false);

            // Amount - Required field
            builder.Property(ar => ar.Amount)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            // Currency - Required field with a max length of 3 characters
            builder.Property(ar => ar.Currency)
                .HasConversion<int>() // Converts the enum to an int for storage
                .IsRequired();

            // Description - Optional field with a max length
            builder.Property(ar => ar.Description)
                .HasMaxLength(500)
                .IsRequired(false);

            // AdvanceType - Enum field as int
            builder.Property(ar => ar.AdvanceType)
                .HasConversion<int>() // Converts the enum to an int for storage
                .IsRequired();

            // EmployeeID - Foreign Key relation with User
            builder.HasOne(ar => ar.Employee)
                .WithMany(u => u.AdvanceRequests)
                .HasForeignKey(ar => ar.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
