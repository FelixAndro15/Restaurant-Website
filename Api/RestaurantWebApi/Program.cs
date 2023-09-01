using RestaurantBusinessLayer.Abstract;
using RestaurantBusinessLayer.Concrete;
using RestaurantDataAccessLayer.Abstract;
using RestaurantDataAccessLayer.Concrete;
using RestaurantDataAccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Context>();
builder.Services.AddScoped<IStaffDal, EfStaffDal>();
builder.Services.AddScoped<IStaffService,StaffManager>();

builder.Services.AddScoped<IFoodDal, EfFoodDal>();
builder.Services.AddScoped<IFoodService,FoodManager>();

builder.Services.AddScoped<ISubscribeDal, EfSubscribeDal>();
builder.Services.AddScoped<ISubscribeService, SubscribeManager>();

builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();

builder.Services.AddScoped<IAboutDal, EfAboutDal>();
builder.Services.AddScoped<IAboutService, AboutManager>();

builder.Services.AddScoped<IBookingDal, EfBookingDal>();
builder.Services.AddScoped<IBookingService, BookingManager>();

builder.Services.AddScoped<IContactDal, EfContactDal>();
builder.Services.AddScoped<IContactService, ContactManager>();

builder.Services.AddScoped<IGuestDal, EfGuestDal>();
builder.Services.AddScoped<IGuestService, GuestManager>();

builder.Services.AddScoped<ISendMessageDal, EfSendMessageDal>();
builder.Services.AddScoped<ISendMessageService, SendMessageManager>();

builder.Services.AddScoped<IMessageCategoryDal, EfMessageCategoryDal>();
builder.Services.AddScoped<IMessageCategoryService, MessageCategoryManager>();

builder.Services.AddAutoMapper(typeof(Program));

//builder.Services.AddScoped<>

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("RestaurantApiCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
/*void ConfigureServices(IServiceCollection services)
{
    services.AddHttpClient();
    services.AddControllersWithViews();
}*/
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("RestaurantApiCors");
app.UseAuthorization();

app.MapControllers();

app.Run();
