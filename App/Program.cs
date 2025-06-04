using App.Components;
using Context;

var builder = WebApplication.CreateBuilder(args);

builder.AddSqlServerDbContext<CafeContext>(connectionName: "grendehus-cafe-db");

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);

    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App.Components.App>()
    .AddInteractiveServerRenderMode();

app.Run();