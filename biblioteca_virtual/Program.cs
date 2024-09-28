using Microsoft.EntityFrameworkCore;
using biblioteca_virtual.Data;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o DbContext e configura a ConnectionString para MySQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("BibliotecaDBConnection"),
        new MySqlServerVersion(new Version(8, 0, 23)) // Ajuste a versão do MySQL conforme necessário
    ));

// Adiciona serviços ao contêiner
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuração do pipeline de requisições
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
