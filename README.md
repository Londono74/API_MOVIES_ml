# API.W.Movies

API REST desarrollada en .NET 8.0 para la gestión de películas y categorías.

## 🚀 Tecnologías

- **.NET 8.0** - Framework principal
- **Entity Framework Core 8.0.21** - ORM para acceso a datos
- **SQL Server** - Base de datos
- **AutoMapper 15.1.0** - Mapeo de objetos
- **Swagger/OpenAPI** - Documentación de API

## 📋 Funcionalidades

### Categorías (Categories)
- ✅ GET `/api/Categories` - Listar todas las categorías
- ✅ GET `/api/Categories/{id}` - Obtener categoría por ID
- ✅ POST `/api/Categories` - Crear nueva categoría
- ✅ PUT `/api/Categories/{id}` - Actualizar categoría
- ✅ DELETE `/api/Categories/{id}` - Eliminar categoría

### Películas (Movies)
- ✅ GET `/api/Movies` - Listar todas las películas
- ✅ GET `/api/Movies/{id}` - Obtener película por ID
- ✅ POST `/api/Movies` - Crear nueva película
- ✅ PUT `/api/Movies/{id}` - Actualizar película
- ✅ DELETE `/api/Movies/{id}` - Eliminar película

## 🏗️ Arquitectura

El proyecto sigue una arquitectura en capas:

- **Controllers** - Manejo de peticiones HTTP
- **Services** - Lógica de negocio
- **Repository** - Acceso a datos
- **DAL (Data Access Layer)** - Modelos y contexto de base de datos
- **DTOs** - Objetos de transferencia de datos

## 📦 Instalación

### Prerrequisitos

- .NET 8.0 SDK
- SQL Server (o SQL Server LocalDB)
- Entity Framework Core Tools

### Pasos

1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/TU-USUARIO/API_MOVIES_ml.git
   ```

2. **Navegar a la carpeta del proyecto:**
   ```bash
   cd API_MOVIES_ml/API.W.Movies-master/API.W.Movies-master/API.W.Movies
   ```

3. **Instalar Entity Framework Core Tools (si no lo tienes):**
   ```bash
   dotnet tool install --global dotnet-ef
   ```

4. **Aplicar migraciones a la base de datos:**
   ```bash
   dotnet ef database update
   ```

5. **Ejecutar el proyecto:**
   ```bash
   dotnet run
   ```

6. **Abrir Swagger:**
   - Navega a: `https://localhost:5299/swagger`

## ⚙️ Configuración

La cadena de conexión se encuentra en `appsettings.json`:

```json
{
  "ConnectionStrings": {
    "SqlConnection": "Server=(localdb)\\MSSQLLocalDB;Database=APIWMovies;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=true"
  }
}
```

Puedes modificar esta cadena según tu configuración de SQL Server.

## 📝 Modelos

### Category
- `Id` (int) - Identificador único
- `Name` (string, max 100) - Nombre de la categoría
- `CreatedDate` (DateTime) - Fecha de creación
- `ModifiedDate` (DateTime?) - Fecha de modificación

### Movie
- `Id` (int) - Identificador único
- `Name` (string, max 100) - Nombre de la película
- `Duration` (int) - Duración en minutos
- `Description` (string?) - Descripción opcional
- `Clasification` (string, max 10) - Clasificación (ej: "PG-13", "R")
- `CreatedDate` (DateTime) - Fecha de creación
- `ModifiedDate` (DateTime?) - Fecha de modificación

## 🔒 Validaciones

### Categorías
- `Name`: Requerido, máximo 100 caracteres
- No se permiten nombres duplicados

### Películas
- `Name`: Requerido, máximo 100 caracteres
- `Duration`: Requerido
- `Clasification`: Requerido, máximo 10 caracteres

## 📚 Documentación

La API está documentada con Swagger. Una vez ejecutado el proyecto, accede a:
- **Swagger UI**: `https://localhost:5299/swagger`
- **OpenAPI JSON**: `https://localhost:5299/swagger/v1/swagger.json`

## 👤 Autor

Desarrollado como parte de la Actividad Evaluativa #4

## 📄 Licencia

Este proyecto es parte de un ejercicio académico.
