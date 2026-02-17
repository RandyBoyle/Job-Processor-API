# Job Processor API
A simple .NET 8 Minimal API for managing background jobs.
Built as a small, real-world example using feature-based structure and clean, readable code.

## 🚀 Features
- Create background jobs
- View all jobs
- View a single job by ID
- Delete jobs

## 🛠 Tech Stack
- .NET 8
- ASP.NET Core Minimal APIs
- Feature-based / module-based structure
- In-memory data store (for simplicity)

## ▶️ Running the API
1. Clone the repository
2. Open the solution in Visual Studio or VS Code
3. Run the project
4. The API will be available at:

http://localhost:5120

## 📌 Example Endpoints
```http
GET    /jobs
GET    /jobs/{id}
POST   /jobs
DELETE /jobs/{id}

## 📄 Sample Request — POST /jobs

{
  "name": "Daily Report Job",
  "description": "Generates daily sales report"
}

## 📄 Sample Response — POST /jobs
{
  "id": 1,
  "name": "Daily Report Job",
  "description": "Generates daily sales report",
  "createdAt": "2026-02-01T15:30:00Z"
}
```

## 🎯 Purpose

This project is intentionally kept small and simple to demonstrate:
- Practical Minimal API usage
- Feature-based API organization
- Proper HTTP status handling
- Clean separation of concerns
