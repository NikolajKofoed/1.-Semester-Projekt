using SejlBåd.Services.BoatService;
using SejlBåd.Services.DockSpotServices;
using SejlBåd.Services.EventServices;
using SejlBåd.Services.SailingClassServices;
using SejlBåd.Services.WeatherServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddTransient<JsonFileBoatService>();
builder.Services.AddSingleton<IDockSpotService, DockSpotService>();
builder.Services.AddTransient<IWeatherService, WeatherService>();
builder.Services.AddSingleton<IBoatService, BoatService>();
builder.Services.AddTransient<JsonFileDockSpotService>();
builder.Services.AddSingleton<IEventService, EventService>();
builder.Services.AddSingleton<ISailingClassService, SailingClassService>();
builder.Services.AddTransient<JsonFileSCService>();

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

