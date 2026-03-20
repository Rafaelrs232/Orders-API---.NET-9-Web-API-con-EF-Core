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