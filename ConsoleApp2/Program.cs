// See https://aka.ms/new-console-template for more information
using HRMaster_API_Project.BLL.Services;
using HRMaster_API_Project.DAL.Context;
using HRMaster_API_Project.DAL.Repositories.Concrete;

Console.WriteLine("Hello, World!");

AppDbContext dbContext = new AppDbContext();    
CompanyManager companyManager =new CompanyManager(dbContext);

var companies = companyManager.GetAllAsync().Result;
foreach(var item in companies)
{
    Console.WriteLine(item.CompanyName);
}
