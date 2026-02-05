# Vibe-Mock

A modern, responsive web application built with .NET Core 8.0, Entity Framework Core, and SQL Server/SQLite.

![Vibe Web Application](https://github.com/user-attachments/assets/f1509486-11ed-4bee-9f60-9a1630ae228d)

## Features

- **Modern UI Design**: Beautiful gradient hero section with smooth animations
- **Responsive Layout**: Works perfectly on all devices (mobile, tablet, desktop)
- **Database-Driven**: Entity Framework Core with SQL Server or SQLite support
- **ASP.NET Core MVC**: Clean architecture following MVC pattern
- **Bootstrap 5**: Modern, mobile-first design framework

## Technology Stack

- **.NET Core 8.0**: Latest version of .NET Core framework
- **ASP.NET Core MVC**: Model-View-Controller architecture
- **Entity Framework Core 8.0**: Object-relational mapping (ORM)
- **SQL Server / SQLite**: Flexible database options
- **Bootstrap 5**: Front-end framework
- **C#**: Programming language

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- **For SQL Server**: [SQL Server LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) (installed with Visual Studio) or SQL Server
- **For SQLite**: No additional installation required (cross-platform)

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

### 3. Configure Database

The application supports both **SQLite** (default, cross-platform) and **SQL Server**.

#### Option A: Use SQLite (Default - Recommended for Development)

No configuration needed! The app uses SQLite by default with `UseSqlite: true` in `appsettings.json`.

#### Option B: Use SQL Server

To switch to SQL Server, update `appsettings.json`:

```json
{
  "UseSqlite": false,
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=VibeMockDb;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
```

For a full SQL Server instance:

```json
{
  "UseSqlite": false,
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=VibeMockDb;User Id=YOUR_USER;Password=YOUR_PASSWORD;TrustServerCertificate=True"
  }
}
```

### 4. Run the Application

```bash
dotnet run
```

The application will:
- Automatically create the database
- Seed initial data (categories and posts)
- Start the web server

The application will be available at:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

## Database Management

### Using Migrations (SQL Server)

If you're using SQL Server and want to manage the database with migrations:

```bash
# Create a new migration
dotnet ef migrations add YourMigrationName

# Update the database
dotnet ef database update
```

### Reset Database

To start fresh:

**SQLite:**
```bash
rm VibeMock.db
dotnet run  # Database will be recreated
```

**SQL Server:**
```bash
dotnet ef database drop
dotnet ef database update
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
│   │   └── site.css    # Custom styles
│   ├── js/
│   └── lib/            # Bootstrap, jQuery
├── Migrations/         # EF Core migrations
├── Program.cs          # Application entry point
└── appsettings.json    # Configuration
```

## Features Implemented

### 1. Hero Section
- Purple gradient background (#667eea to #764ba2)
- Animated content with fade-in effects
- Call-to-action button with smooth scrolling

### 2. Posts Display
- Dynamic data from database
- Card-based layout with hover effects
- Category badges (Technology, Lifestyle, Music)
- Author and date information

### 3. Features Section
- Three feature boxes with SVG icons
- Hover animations
- Responsive grid layout
- Describes key technologies

### 4. Responsive Design
- Mobile-first approach
- Breakpoints for different screen sizes
- Touch-friendly interface

## Development

### Adding New Features

1. **Add a new model** in `/Models`
2. **Update DbContext** in `/Data/ApplicationDbContext.cs`
3. **Create migration** (if using SQL Server): `dotnet ef migrations add NewFeature`
4. **Update database**: `dotnet ef database update`
5. **Add controller actions** and **views**

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

1. Create a new action in `HomeController.cs` (or new controller)
2. Add a corresponding view in the `Views` folder
3. Update navigation in `Views/Shared/_Layout.cshtml`

### Modifying Database Seed Data

Edit `/Data/ApplicationDbContext.cs` in the `OnModelCreating` method.

## Troubleshooting

### SQLite Issues

If you encounter SQLite errors, ensure the app has write permissions in the application directory.

### SQL Server Connection Issues

If you encounter database connection errors:
1. Ensure SQL Server LocalDB is installed: `sqllocaldb info`
2. Check the connection string in `appsettings.json`
3. Try starting LocalDB: `sqllocaldb start mssqllocaldb`

### Migration Errors

To reset migrations (SQL Server):
```bash
dotnet ef database drop
dotnet ef migrations remove
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## Screenshots

### Homepage
![Homepage](https://github.com/user-attachments/assets/f1509486-11ed-4bee-9f60-9a1630ae228d)

The homepage features:
- Modern purple gradient hero section
- Latest posts from the database
- Feature highlights section
- Fully responsive design

## License

This project is open source and available under the MIT License.

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## Support

For issues, questions, or suggestions, please open an issue on GitHub.