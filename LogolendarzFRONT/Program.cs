using LogolendarzFRONT.Service.IService;
using LogolendarzFRONT.Service;
using LogolendarzFRONT.Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMvc();
builder.Services.AddHttpContextAccessor();
builder.Services.AddHttpClient();
builder.Services.AddHttpClient<IVisitService, VisitService>();
builder.Services.AddHttpClient<IAuthService, AuthService>();
SD.VisitAPIBase = builder.Configuration["ServicesUrls:VisitAPI"];
SD.AuthAPIBase = builder.Configuration["ServicesUrls:AuthAPI"];

builder.Services.AddScoped<IBaseService, BaseService>();
builder.Services.AddScoped<IVisitService, VisitService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddControllersWithViews();

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
