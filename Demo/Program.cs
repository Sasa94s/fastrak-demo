using Demo.Data;
using Demo.Filters;
using Demo.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DemoDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DemoDb"));
});

builder.Services.AddScoped<WebhookAuthFilter>();

using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DemoDbContext>();
    db.Database.Migrate();
}

builder.Services.AddControllers();

builder.Services.AddScoped<IWebhookManager, WebhookManager>();

var app = builder.Build();

app.MapControllers();

app.Run();