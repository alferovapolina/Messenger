using Messenger.DataModels;
using Messenger.Components;
using Microsoft.EntityFrameworkCore.Design;
using Messenger;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<IDesignTimeDbContextFactory<ApplicationContext>, ApplicationContextFactory>();
builder.Services.AddScoped<ApplicationContextFactory>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();
ApplicationContextFactory factory = new ApplicationContextFactory();
using (var context = factory.CreateDbContext())
{
    context.Database.Migrate();
}

app.Run();
