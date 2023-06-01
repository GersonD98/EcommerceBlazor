using EcommerceApp.DataAccess;
using EcommerceApp.Entities;
using EcommerceBlazor.Shared;
using EcommerceBlazor.Shared.Response;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<EcommerceDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("EcommerceDB"));
}
);
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.MapGet("api/Categorias", async (EcommerceDbContext context) =>
{
    var categorias = await context.Set<Categoria>()
    .Where(c => c.Estado)
    .Select(p => new CategoriaDto
    {
        Id = p.Id,
        Nombre = p.NombreCategoria
    })
    .AsNoTracking()
    .ToListAsync();

    return Results.Ok(categorias);
});

app.Run();
