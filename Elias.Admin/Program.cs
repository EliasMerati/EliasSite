using Elias.Admin.Configuration;
using Elias.Data.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
#region Services
var services = builder.Services;
services.AddRazorPages();
services.Configuration();
services.AddAuthentication(opt =>
{
    opt.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    opt.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    opt.DefaultSignOutScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(o =>
{
    o.LoginPath = "/Login";
    o.ExpireTimeSpan = TimeSpan.FromDays(30);
    o.LogoutPath = "/LogOut";
});
services.AddDbContext<DatabaseContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("EliasConnectionString")),ServiceLifetime.Transient);
#endregion
// Add services to the container.

#region Middlewares
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
#endregion

