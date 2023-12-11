using SejlB�d.Models;
using SejlB�d.Services.AccountServices;
using SejlB�d.Services.BlogServices;
using SejlB�d.Services.BoatService;
using SejlB�d.Services.ContactService;
using SejlB�d.Services.CustomerServices;
using SejlB�d.Services.DockSpotServices;
using SejlB�d.Services.EventServices;
using SejlB�d.Services.OrderServices;
using SejlB�d.Services.SailingClassServices;
using SejlB�d.Services.WeatherServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddTransient<JsonFileBoatService>();
builder.Services.AddSingleton<IDockSpotService, DockSpotService>();
builder.Services.AddTransient<IWeatherService, WeatherService>();
builder.Services.AddSingleton<IContactService, ContactService>();
builder.Services.AddSingleton<IBoatService, BoatService>();
builder.Services.AddTransient<JsonFileDockSpotService>();
builder.Services.AddSingleton<IEventService, EventService>();
builder.Services.AddTransient<JsonFileEventService>();
builder.Services.AddSingleton<ISailingClassService, SailingClassService>();
builder.Services.AddTransient<JsonFileSailingClassService>();
builder.Services.AddSingleton<IOrderService, OrderService>();
builder.Services.AddTransient<JsonFileOrderService>();
builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddTransient<JsonFileCustomerService>();
builder.Services.AddSingleton<IBlogService, BlogService>();
builder.Services.AddTransient<JsonFileBlogService>();
builder.Services.AddSingleton<IAccountService, AccountService>();
builder.Services.AddTransient<JsonFileAccountService>();
builder.Services.AddTransient<JsonFileContactService>();


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

