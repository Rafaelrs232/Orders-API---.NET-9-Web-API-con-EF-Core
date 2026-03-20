using Microsoft.EntityFrameworkCore;
using OrdersApi.Data;
using OrdersApi.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// -------------------------
// 1️⃣ Configurar servicios
// -------------------------
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar DbContext con SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar OrderService
builder.Services.AddScoped<OrderService>();

var app = builder.Build();

// -------------------------
// 2️⃣ Middleware
// -------------------------
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Desactivamos HTTPS para pruebas locales
// app.UseHttpsRedirection();
app.UseAuthorization();

// -------------------------
// 3️⃣ Mapear controllers
// -------------------------
app.MapControllers();

// -------------------------
// 4️⃣ Mensaje de arranque
// -------------------------
Console.WriteLine("✅ Orders API corriendo en http://localhost:5000");

// -------------------------
// 5️⃣ Ejecutar app
// -------------------------
app.Run();