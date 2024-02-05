using Microsoft.AspNetCore.Authentication.Cookies;
using PontoEletronico;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<AdminCartaoPonto>(); 
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = "/Login/Index"; // Set the login page URL
    options.LogoutPath = "/Login/Logout"; // Set the logout page URL
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PontoEletronico}/{action=Index}/{id?}");

app.Run();