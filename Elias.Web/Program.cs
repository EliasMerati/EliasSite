using Elias.Admin.Configuration;
using Elias.Data.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using WebMarkupMin.AspNetCore8;

var builder = WebApplication.CreateBuilder(args);
#region Services
var services = builder.Services;
// Add services to the container.
services.AddControllersWithViews();
services.Configuration();
services.AddMvc();

#region Minify Html
services.AddWebMarkupMin(
options =>
{
options.AllowMinificationInDevelopmentEnvironment = true;
options.AllowCompressionInDevelopmentEnvironment = true;
})
.AddHtmlMinification(
options =>
{
    options.MinificationSettings.RemoveRedundantAttributes = true;
    options.MinificationSettings.RemoveHttpProtocolFromAttributes = true;
    options.MinificationSettings.RemoveHttpsProtocolFromAttributes = true;

})
.AddHttpCompression();
#endregion

#region Configure Limit File For Mac & Linux
services.Configure<FormOptions>(opt => opt.MultipartBodyLengthLimit = 52428800);
#endregion

#region Authentication
services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    opt.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
});
#endregion

services.AddDbContext<DatabaseContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("EliasConnectionString"), builder =>
{
    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
}));
#endregion

#region Middlewares
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
#endregion

