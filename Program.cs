using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MoneyApp.Data;
using Microsoft.AspNetCore.Authentication;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddBlazorise( options =>
      {
        options.ChangeTextOnKeyPress = true; // optional
      } )
      .AddBootstrapProviders()
      .AddFontAwesomeIcons();

builder.Services.AddDbContext<DatabaseContext>(options => options.UseLazyLoadingProxies().UseSqlite(builder.Configuration.GetConnectionString("MoneyDb")));
// add google authentication
builder.Services.AddAuthentication("Cookies").AddCookie(opt =>
{
    opt.Cookie.Name = "GoogleOAuth";
    opt.LoginPath = "/Login";
})
.AddGoogle(opt => 
{
    opt.ClientId = builder.Configuration["Google:ClientId"];
    opt.ClientSecret = builder.Configuration["Google:ClientSecret"];
    opt.Scope.Add("profile");
});

// add new claim - role
builder.Services.AddScoped<IClaimsTransformation, UserInfoClaims>();

builder.Services.AddAuthorization(
    config => { config.AddPolicy("IsAdmin", policy => policy.RequireClaim("Role", "Admin"));
});


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
app.UseCookiePolicy();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
