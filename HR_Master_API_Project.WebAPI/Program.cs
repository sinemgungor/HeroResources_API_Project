using HRMaster_API_Project.DAL.Context;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Identity;
using HRMaster_API_Project.DAL.Repositories.Concrete;
using HRMaster_API_Project.BLL.Services;
using HRMaster_API_Project.BLL.Services.CompanyService;
using HRMaster_API_Project.BLL.Services.AdminService;
using HRMaster_API_Project.BLL.Services.ManagerService;
using HRMaster_API_Project.BLL.Mapper;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.BLL.Services.DepartmentService;
using HRMaster_API_Project.BLL.Services.LoginService;
using HRMaster_API_Project.BLL.Services.EmployeeService;
using HRMaster_API_Project.BLL.Services.ExpenseRequestService;
using HRMaster_API_Project.BLL.Services.LeaveRequestService;
using HRMaster_API_Project.BLL.Services.AdvanceRequestService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Identity
builder.Services.AddIdentity<User, Role>(options =>
{

    options.SignIn.RequireConfirmedAccount = true;
})
    .AddEntityFrameworkStores<AppDbContext>()
    .AddRoles<Role>()
    .AddDefaultTokenProviders(); // Varsayýlan token saðlayýcýlarýný ekleyin
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(CompanyMapper)));
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(DepartmentMapper)));
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(ManagerMapper)));
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(EmployeeMapper)));
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(ExpenseRequestMapper)));
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(LeaveRequestMapper)));
builder.Services.AddAutoMapper(x => x.AddProfile(typeof(AdvanceRequestMapper)));
builder.Services.AddHttpContextAccessor();

// Scoped services
builder.Services.AddScoped<IAdminService, AdminServices>();
builder.Services.AddScoped<IEmailSender, EmailSender>();
builder.Services.AddScoped<IManagerServices, ManagerServices>();
builder.Services.AddScoped<UserHelper>();
builder.Services.AddTransient<ICompanyService, CompanyService>();
builder.Services.AddTransient<ICompanyManager, CompanyManager>();
builder.Services.AddTransient<IDepartmentManager, DepartmentManager>();
builder.Services.AddTransient<IDepartmentService,DepartmantService>();
builder.Services.AddTransient<ILoginServices,LoginServices>();
builder.Services.AddTransient<IEmployeeServices,EmployeeServices>();
builder.Services.AddTransient<IExpenseRequestService,ExpenseRequestService>();
builder.Services.AddTransient<IExpenseRequestManager,ExpenseRequestManager>();
builder.Services.AddTransient<ILeaveRequestManager,LeaveRequestManager>();
builder.Services.AddTransient<ILeaveRequestServices, LeaveRequestServices>();
builder.Services.AddScoped<IAdvanceRequestServices, AdvanceRequestServices>();
builder.Services.AddScoped<IAdvanceRequestManager, AdvanceRequestManager>();


// SMTP ayarlarýný yapýlandýrýn
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();