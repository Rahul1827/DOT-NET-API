using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.MapControllerRoute(
    name:"default",
    pattern:"{Controller=Home}/{action=Index }/{id?}"

    );
app.UseStaticFiles();

app.Run();
