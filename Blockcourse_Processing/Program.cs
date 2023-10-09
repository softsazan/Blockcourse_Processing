using Blockcourse_Processing.Core.Servies;
using Blockcourse_Processing.Core.Servies.InterFace;
using Blockcourse_Processing.DataLayer.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region DbContext
var connectionString = builder.Configuration.GetConnectionString("TikTolkConnection");
builder.Services.AddDbContext<TikTokDbContext>(options => options.UseSqlServer(connectionString));
#endregion

#region IOC
builder.Services.AddTransient<ISpotifyServies,SpotifyServies>();    
builder.Services.AddTransient<ITikTokServies,TikTokServies>();    
builder.Services.AddTransient<IYouTubeServies,YouTubeServies>();    

#endregion

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
