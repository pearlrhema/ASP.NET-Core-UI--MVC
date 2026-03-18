# 🎬 MvcMovie Application

## 📌 Overview

The **MvcMovie** application is an ASP.NET Core MVC web application developed as part of a tutorial exercise. The project demonstrates how to build a dynamic web application using the Model-View-Controller (MVC) design pattern, Entity Framework Core, and Razor views.

The application allows users to manage a movie database by performing basic CRUD (Create, Read, Update, Delete) operations.

---

## 🚀 Features Implemented

- Create new movie records
- View a list of movies
- Edit existing movie details
- Delete movies
- Filter/search movies by genre and title
- Data validation using model attributes
- Database integration using Entity Framework Core
- Seed data initialization for default movie entries

---

## 🛠️ Technologies and Environment

### 🔹 Development Environment

- Visual Studio Code
- .NET SDK (version 9.0+)
- Windows OS

### 🔹 Frameworks & Tools

- ASP.NET Core MVC
- Entity Framework Core
- Razor View Engine (`.cshtml`)
- SQLite (local database)
- C# Programming Language

### 🔹 Key Commands Used

```bash
dotnet new mvc
dotnet watch run
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

## 🗂️ Project Structure

- **Models/** – Contains data models such as `Movie`
- **Views/** – Contains Razor view files (`.cshtml`)
- **Controllers/** – Handles application logic and user requests
- **Data/** – Contains database context class
- **Migrations/** – Stores database migration files
- **wwwroot/** – Static files (CSS, JS, images)

---

## 🗄️ Database Configuration

The application uses **SQLite** as a local database with the following connection string:

```json
"ConnectionStrings": {
  "MvcMovieContext": "Data Source=MvcMovie.db"
}
```

The database is automatically created and updated using Entity Framework Core migrations.

---

## 🌱 Data Seeding

A `SeedData` class is implemented to populate the database with initial movie data when the application starts.

---

## ▶️ How to Run the Application

1. Open the project folder in the terminal
2. Run the following command:

```bash
dotnet watch run
```

3. Open the browser and navigate to:

```
https://localhost:xxxx
```

---

## 📚 Learning Outcomes

Through this tutorial, the following concepts were learned:

- Understanding the MVC architecture
- Working with Razor syntax (`.cshtml`)
- Performing database operations with Entity Framework Core
- Managing migrations and database updates
- Implementing form validation and user input handling
- Using Hot Reload (`dotnet watch`) for efficient development

---

## 📖 Resources

- Microsoft ASP.NET Core Documentation
- Entity Framework Core Documentation
- Razor Pages and MVC Tutorials
- C# Programming Guide

---

## ✅ Conclusion

This project provided hands-on experience in building a full-stack web application using ASP.NET Core. It reinforced key concepts in web development, database integration, and application structure using the MVC pattern.
