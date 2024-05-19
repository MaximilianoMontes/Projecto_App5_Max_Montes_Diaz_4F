using Microsoft.EntityFrameworkCore;
using Projecto_App5_Max_Montes_Diaz_4F.Client.Pages;
using Projecto_App5_Max_Montes_Diaz_4F.Components;
using Projecto_App5_Max_Montes_Diaz_4F.Modelos;
using Projecto_App5_Max_Montes_Diaz_4F.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CatalogoDBContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("PrimerServer")));
builder.Services.AddScoped<IRepositorioPersonas, RepositorioPersonas>();
builder.Services.AddScoped<IRepositorioReservas, RepositorioRservas>();
builder.Services.AddScoped<IRepositorioUsuarios, RepositorioUsuarios>();
builder.Services.AddScoped<IRepositorioVehiculo, RepositorioVehiculos>();
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(Projecto_App5_Max_Montes_Diaz_4F.Client._Imports).Assembly);

app.Run();
