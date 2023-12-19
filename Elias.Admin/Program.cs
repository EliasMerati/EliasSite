using Elias.Data.Context;

var builder = WebApplication.CreateBuilder(args);
#region Services
var services = builder.Services;
services.AddRazorPages();

services.AddDbContext<DatabaseContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("EliasConnectionString")));
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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
#endregion

