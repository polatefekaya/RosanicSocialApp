using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RosanicSocial.Application;
using RosanicSocial.Domain.IdentityEntities;
using RosanicSocial.Infrastructure;
using RosanicSocial.Infrastructure.DatabaseContext;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddMvc();
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

//Custom services
builder.Services.AddApplication();
builder.Services.AddInfrastructure();

builder.Services.AddDbContext<ApplicationDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders()
    .AddUserStore<UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, Guid>>()
    .AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>();

var app = builder.Build();

app.UseAuthentication();
app.UseRouting();
app.UseStaticFiles();
app.MapControllers();

app.Run();
