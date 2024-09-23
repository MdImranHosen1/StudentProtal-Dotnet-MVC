
# Student Portal

A simple ASP.NET Core MVC application for managing student records. This project demonstrates basic CRUD (Create, Read, Update, Delete) operations using Entity Framework Core.

## Features

- Add new students to the database.
- View a list of all students.
- Edit student details.
- Delete a student record.

## Technologies Used

- **ASP.NET Core MVC**: Framework for building the web application.
- **Entity Framework Core**: ORM (Object-Relational Mapping) for data access.
- **Bootstrap**: Front-end framework for responsive design.
- **SQL Server**: Database for storing student records.

## Project Structure

```plaintext
├───.github
│   └───workflows
├───Assets
└───StudentProtal
    ├───Controllers
    ├───Data
    ├───Migrations
    ├───Models
    │   └───Entity
    ├───Properties
    ├───Views
    │   ├───Home
    │   ├───Shared
    │   └───Students
```

## Getting Started

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server 2022](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express)

### Installation

1. **Clone the repository**:

   ```bash
   git clone https://github.com/your-username/StudentPortal.git
   cd StudentPortal
   ```

2. **Set up the database connection**:

   Update the `DefaultConnection` string in `appsettings.json` with your SQL Server instance details:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=StudentPortalDb;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```

3. **Apply Migrations**:

   Apply the initial database migration to create the schema:

   ```bash
   dotnet ef database update
   ```

4. **Run the Application**:

   ```bash
   dotnet run
   ```

5. **Visit in Browser**:

   Open your browser and navigate to `https://localhost:5001` to access the application.

### Usage

1. **Add a Student**:

   - Click on the "Add Student" link in the navigation menu.
   - Fill in the student's details and click the "Submit" button.

2. **View Students**:

   - Navigate to the "Student List" page to view all students in the database.

3. **Edit Student**:

   - Click the "Edit" button next to a student's name to modify their details.

4. **Delete Student**:

   - Click the "Delete" button next to a student's name to remove them from the database.

## Known Issues

- Deleting a student might fail if the anti-forgery token is missing. Ensure that the `@Html.AntiForgeryToken()` is included in the delete form.

## Screensort

![alt text](assets/image.png)
![alt text](assets/image-2.png)
![alt text](assets/image-1.png)