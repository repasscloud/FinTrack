using Microsoft.EntityFrameworkCore;
using FinTrack.Data;
using FinTrack.Services;
using FinTrack.Services.Interfaces;

namespace FinTrack;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=./Data/AppDb.sqlite")
        );

        // Add services to the container.
        builder.Services.AddHttpClient();
        builder.Services.AddRazorPages();
        builder.Services.AddServerSideBlazor();
        builder.Services.AddScoped<IBasicClientService, BasicClientService>();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
        }


        app.UseStaticFiles();

        app.UseRouting();

        app.MapBlazorHub();
        app.MapFallbackToPage("/_Host");

        app.Run();
    }
}

