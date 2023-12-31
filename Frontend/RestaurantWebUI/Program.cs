using Microsoft.AspNetCore.Identity;
using RestaurantDataAccessLayer.Concrete;
using RestaurantEntityLayer.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.DataProtection;
using FluentValidation.AspNetCore;
using FluentValidation;
using RestaurantWebUI.Dtos.GuestDto;
using RestaurantWebUI.ValidationRules.GuestValidationRules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IValidator<CreateGuestDto>, CreateGuestValidator>();
builder.Services.AddTransient<IValidator<UpdateGuestDto>, UpdateGuestValidator>();
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));

});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan=TimeSpan.FromMinutes(5);
    options.LoginPath = "/Login/Index/";
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
void ConfigureServices(IServiceCollection services)
{
    //builder.Services.AddDbContext<Context>();
    //builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
    //builder.Services.AddHttpClient();
    //builder.Services.AddControllersWithViews();
    ////builder.Services.AddIdentity<IdentityUser, IdentityRole>();
    //builder.Services.AddAutoMapper(typeof(Program));
}
app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
