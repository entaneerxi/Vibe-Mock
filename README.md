# Vibe-Mock

A modern, responsive web application built with .NET Core 8.0, Entity Framework Core, and SQL Server.

## Features

- **Modern UI Design**: Beautiful gradient hero section with smooth animations
- **Responsive Layout**: Works perfectly on all devices (mobile, tablet, desktop)
- **Database-Driven**: Entity Framework Core with SQL Server
- **ASP.NET Core MVC**: Clean architecture following MVC pattern
- **Bootstrap 5**: Modern, mobile-first design framework

## Technology Stack

- **.NET Core 8.0**: Latest version of .NET Core framework
- **ASP.NET Core MVC**: Model-View-Controller architecture
- **Entity Framework Core 8.0**: Object-relational mapping (ORM)
- **SQL Server**: Microsoft SQL Server database (LocalDB for development)
- **Bootstrap 5**: Front-end framework
- **C#**: Programming language

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) (installed with Visual Studio) or SQL Server

## Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/entaneerxi/Vibe-Mock.git
cd Vibe-Mock/VibeMock
```

### 2. Restore Dependencies

```bash
dotnet restore
```

### 3. Update Database

Apply migrations to create the database:

```bash
dotnet ef database update
```

This will create a database named `VibeMockDb` in your LocalDB instance with sample data.

### 4. Run the Application

```bash
dotnet run
```

The application will start and be available at:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

## Database Configuration

The default connection string in `appsettings.json` uses SQL Server LocalDB:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=VibeMockDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```

### Using SQL Server

To use a full SQL Server instance, update the connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=VibeMockDb;User Id=YOUR_USER;Password=YOUR_PASSWORD;TrustServerCertificate=True"
}
```

## Project Structure

```
VibeMock/
├── Controllers/         # MVC Controllers
│   └── HomeController.cs
├── Data/               # Database context
│   └── ApplicationDbContext.cs
├── Models/             # Data models
│   ├── Post.cs
│   ├── Category.cs
│   └── ErrorViewModel.cs
├── Views/              # Razor views
│   ├── Home/
│   │   ├── Index.cshtml
│   │   └── Privacy.cshtml
│   └── Shared/
│       └── _Layout.cshtml
├── wwwroot/            # Static files
│   ├── css/
│   ├── js/
│   └── lib/
├── Migrations/         # EF Core migrations
├── Program.cs          # Application entry point
└── appsettings.json    # Configuration
```

## Features Implemented

### 1. Hero Section
- Gradient background with purple theme
- Animated content (fade-in effect)
- Call-to-action button

### 2. Posts Display
- Dynamic data from database
- Card-based layout
- Category badges
- Author and date information

### 3. Features Section
- Three feature boxes with icons
- Hover effects
- Responsive grid layout

## Development

### Adding New Migrations

After modifying models:

```bash
dotnet ef migrations add YourMigrationName
dotnet ef database update
```

### Building for Production

```bash
dotnet publish -c Release -o ./publish
```

## Customization

### Changing Colors

Edit `/wwwroot/css/site.css`:
- Hero gradient: `.hero-section` background
- Primary color: `#667eea`
- Secondary color: `#764ba2`

### Adding New Pages

1. Create a new action in a controller
2. Add a corresponding view in the Views folder
3. Update navigation in `_Layout.cshtml`

## Troubleshooting

### Database Connection Issues

If you encounter database connection errors:
1. Ensure SQL Server LocalDB is installed
2. Check the connection string in `appsettings.json`
3. Try running: `sqllocaldb start mssqllocaldb`

### Migration Errors

To reset migrations:
```bash
dotnet ef database drop
dotnet ef migrations remove
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## License

This project is open source and available under the MIT License.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.