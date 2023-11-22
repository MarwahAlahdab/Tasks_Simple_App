# Tasks_Simple_App


This is a simple Task Management application built using ASP.NET MVC for managing tasks.

## Getting Started

Steps to run the application locally:


### Installation

1. Clone this repository

2. Open the solution in Visual Studio.

3. Update the database:
   
    Run the following command on Package Manager Console, to apply migrations and update the database:
   
   ```bash
   Tools -> NuGet Package Manager -> Package Manager Console
   ```

   ```bash
   Update-Database
   ```

### Running the Application

1. Set the `TaskManagement` project as the startup project.

2. Press `Ctrl + F5` or click on the "Start" button to run the application.

3. Open a web browser and navigate to `https://localhost:yourport/` to view the application.

4. Features :

- The application allows you to manage tasks:
  - View your tasks list
  - View task details
  - Add a new task
  - Edit existing tasks
  - Delete tasks

## Technologies Used

- ASP.NET MVC
- Entity Framework Core
- Bootstrap
