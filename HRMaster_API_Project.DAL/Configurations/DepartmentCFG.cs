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
    public class DepartmentCFG : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // Departmanın yöneticisi ile ilişkisi
            builder.HasData(
            new Department { ID = 1, DepartmentName = "İnsan Kaynakları", CompanyID = 1 },
            new Department { ID = 2, DepartmentName = "Finans", CompanyID = 1 },
            new Department { ID = 3, DepartmentName = "Pazarlama", CompanyID = 1 },
            new Department { ID = 4, DepartmentName = "Teknoloji", CompanyID = 1 },
            new Department { ID = 5, DepartmentName = "Satış", CompanyID = 1 },
            new Department { ID = 6, DepartmentName = "Mühendislik", CompanyID = 1 }
            );
            builder.HasData(            // XYZ Inc. Şirketi için departmanlar
            new Department { ID = 7, DepartmentName = "İnsan Kaynakları", CompanyID = 2 },
            new Department { ID = 8, DepartmentName = "Satış", CompanyID = 2 },
            new Department { ID = 9, DepartmentName = "Mühendislik", CompanyID = 2 },
            new Department { ID = 10, DepartmentName = "Ar-Ge", CompanyID = 2 },
            new Department { ID = 11, DepartmentName = "Pazarlama", CompanyID = 2 },
            new Department { ID = 12, DepartmentName = "Lojistik", CompanyID = 2 },
                              
            // QRS Corp. ŞirkeDi için departmanlar
            new Department { ID = 13, DepartmentName = "Lojistik", CompanyID = 3 },
            new Department { ID = 14, DepartmentName = "İnsan Kaynakları", CompanyID = 3 },
            new Department { ID = 15, DepartmentName = "Finans", CompanyID = 3 },
            new Department { ID = 16, DepartmentName = "Teknoloji", CompanyID = 3 },
            new Department { ID = 17, DepartmentName = "Pazarlama", CompanyID = 3 },
            new Department { ID = 18, DepartmentName = "Satış", CompanyID = 3 },
                              
            // LMN LLC. ŞirketD için departmanlar
            new Department { ID = 19, DepartmentName = "Teknoloji", CompanyID = 4 },
            new Department { ID = 20, DepartmentName = "Satış", CompanyID = 4 },
            new Department { ID = 21, DepartmentName = "Pazarlama", CompanyID = 4 },
            new Department { ID = 22, DepartmentName = "Ar-Ge", CompanyID = 4 },
            new Department { ID = 23, DepartmentName = "Mühendislik", CompanyID = 4 },
            new Department { ID = 24, DepartmentName = "Lojistik", CompanyID = 4 }
                              
            );


            // Şirket ile departman ilişkisi
            builder
                .HasOne(d => d.Company)
                .WithMany(c => c.Departments)
                .HasForeignKey(d => d.CompanyID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(d => d.DepartmentName)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
