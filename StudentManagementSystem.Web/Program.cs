using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.BLL.Services;
using StudentManagementSystem.DAL;
using StudentManagementSystem.DAL.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StudentManagementDBcontext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
} );

builder.Services.AddScoped<StudentRepository>();
builder.Services.AddScoped<StudentServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//dotnet ef migrations add "update fluent Api" --project StudentManagementSystem.DAL --startup-project StudentManagementSystem.Web
