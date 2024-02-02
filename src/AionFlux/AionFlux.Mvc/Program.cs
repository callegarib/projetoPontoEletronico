using PontoEletronico;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<AdminCartaoPonto>(); 
builder.Services.AddControllersWithViews();

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