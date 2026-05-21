using HouseholdUtilitiesWeb.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddAntiforgery(options =>
{
    options.SuppressXFrameOptionsHeader = true;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.Use(async (context, next) =>
{
    context.Response.OnStarting(() =>
    {
        context.Response.Headers.Remove("X-Frame-Options");

        context.Response.Headers["Content-Security-Policy"] =
            "frame-ancestors 'self' https://kallamsamad.co.uk https://www.kallamsamad.co.uk http://kallamsamad.co.uk http://www.kallamsamad.co.uk;";

        return Task.CompletedTask;
    });

    await next();
});

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();