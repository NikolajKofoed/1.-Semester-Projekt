using SejlBåd.Services.BoatService;
using SejlBåd.Services.MemberServices;
using SejlBåd.Services.WeatherServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddTransient<IMemberService, MemberService>();
builder.Services.AddTransient<JsonFileMemberService>();
builder.Services.AddTransient<IWeatherService, WeatherService>();
builder.Services.AddSingleton<IBoatService, BoatService>();

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

