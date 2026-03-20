# Orders API - .NET 9 Web API con EF Core

Este proyecto es una **API REST de ejemplo** desarrollada en **.NET 9**.  
Permite gestionar órdenes (`Order`) usando **Entity Framework Core** y se documenta automáticamente con **Swagger/OpenAPI**.

---

## Características

- API REST con endpoints `GET` y `POST` para `Order`
- Uso de **DTOs** para separar el modelo de dominio de la capa de presentación
- **Entity Framework Core** para persistencia en SQL Server
- Documentación interactiva con **Swagger**
- Estructura lista para **inyección de dependencias** y futuras extensiones

---

## Requisitos para ejecutar

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- SQL Server (LocalDB o cualquier instancia accesible)
- Visual Studio 2022 / Visual Studio Code / PowerShell

---

## Cómo levantar el proyecto

1. Clonar el repositorio

```bash
git clone https://github.com/tuusuario/OrdersApi.git
cd OrdersApi/OrdersApi
```

2. Restaurar paquetes NuGet
```bash
dotnet restore
dotnet build
````

3. Si quieres usar migraciones EF Core y crear la base de datos automáticamente:
```bash
dotnet tool install --global dotnet-ef
dotnet ef database update
```

4. Ejecuta la API en un puerto fijo para desarrollo local:
```bash
Ejecuta la API en un puerto fijo para desarrollo local:
````

5.dotnet run --urls "http://localhost:5000"
```bash
http://localhost:5000/swagger/index.html
````


Desde Swagger puedes probar:

GET /api/orders → listar pedidos

GET /api/orders/{id} → obtener un pedido por ID

POST /api/orders → crear un nuevo pedido usando OrderDTO


Notas técnicas

Program.cs configura: Controllers (builder.Services.AddControllers()), Swagger (builder.Services.AddSwaggerGen()), EF Core (builder.Services.AddDbContext<AppDbContext>()) e inyección de dependencias (builder.Services.AddScoped<OrderService>()).

OrderDTO: utilizado para recibir datos de la API y mantener el modelo de dominio seguro.

Order: entidad principal usada por EF Core.

La API está configurada para desarrollo local con HTTP; HTTPS puede habilitarse para producción.


Buenas prácticas

Separación de capas: Controllers, Services y Data (DbContext)

Uso de DTOs para exponer solo lo necesario al cliente

Documentación automática con Swagger

Inyección de dependencias para servicios



Archivos importantes

Program.cs → configuración principal de la API

Controllers/OrdersController.cs → endpoints de Orders

Data/AppDbContext.cs → EF Core DbContext

Services/OrderService.cs → lógica de negocio

DTOs/OrderDTO.cs → objetos de transferencia de datos

Models/Order.cs → entidad de dominio

appsettings.json → cadena de conexión a SQL Server y configuración



Comandos útiles

Restaurar paquetes y compilar: dotnet restore && dotnet build

Ejecutar: dotnet run --urls "http://localhost:5000"

Migraciones EF Core: Crear migración: dotnet ef migrations add NombreMigracion, aplicar migración: dotnet ef database update





