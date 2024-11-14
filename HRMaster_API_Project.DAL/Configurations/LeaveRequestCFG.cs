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
    public class LeaveRequestCFG : IEntityTypeConfiguration<LeaveRequest>
    {
        public void Configure(EntityTypeBuilder<LeaveRequest> builder)
        {
            builder.HasKey(lr => lr.ID);

            // LeaveType - Enum field as int
            builder.Property(lr => lr.LeaveType)
                .HasConversion<int>() // Converts the enum to an int for storage
                .IsRequired();

            // LeaveStartingDate ve LeaveEndDate - DateOnly olarak saklanır, SQL Server'da DateTime olarak
            builder.Property(lr => lr.LeaveStartingDate)
                .HasColumnType("date");
            builder.Property(lr => lr.LeaveEndDate)
                .HasColumnType("date");

            // LeaveDays - Required field
            builder.Property(lr => lr.LeaveDays)
                .IsRequired();

            // ApprovalStatus - Enum field as int
            builder.Property(lr => lr.ApprovalStatus)
                .HasConversion<int>() // Converts the enum to an int for storage
                .IsRequired();

            // ResponseDate - Optional field
            builder.Property(lr => lr.ResponseDate)
                .IsRequired(false);

            // RequestDate - Required field
            builder.Property(lr => lr.RequestDate)
                .IsRequired();

            // EmployeeID - Foreign Key relation with User
            builder.HasOne(lr => lr.Employee)
                .WithMany(u => u.LeaveRequests)
                .HasForeignKey(lr => lr.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
