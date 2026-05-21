using HouseholdUtilitiesWeb.Components;

var builder = WebApplication.CreateBuilder(args);

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

app.Use(async (context, next) =>
{
    context.Response.Headers.Remove("X-Frame-Options");

    context.Response.Headers["Content-Security-Policy"] =
        "frame-ancestors 'self' https://kallamsamad.co.uk http://kallamsamad.co.uk";

    await next();
});

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();


app.Run();
