using AppTest.Data;
using AppTest.Services;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//conection string 
var connectionString = builder.Configuration.GetConnectionString("DocumentManagementContextConnection") ?? throw new InvalidOperationException("Connection string 'DocumentManagementContextConnection' not found.");
builder.Services.AddDbContext<ApplicationDBContext>(options =>
   options.UseSqlServer(connectionString));


builder.Services.AddScoped<IDataCollectionGenerator, DataCollectionGenerator>();

builder.WebHost.ConfigureKestrel(opt =>
{
    opt.Limits.MaxRequestBodySize = null;  //disable the request body limit.
});

builder.Services.Configure<FormOptions>(options =>
{
    options.ValueLengthLimit = int.MaxValue;
    options.MultipartBodyLengthLimit = int.MaxValue;
});


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
