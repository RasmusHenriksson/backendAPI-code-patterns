# BackendAPI Code-Patterns
In this repository we have a backendAPI using ASP.NET Core WEB-API as our Backend.
We also have a SQL server database using Entity Framework core.

# Languages, libraries & frameworks
- ASP.NET Core WEB API
- C#

# Assignment
`MVC`
`Single Responsibility Principle`
`Open Closed Principle`
`Liskov Substitution Principle`
`Interface Segregation Principle`
`Dependency Inversion Principle`

# INFORMATION

I have made comments and structured my code following the SOLID Principles from my best ability.
The comments are displayed in every class and are easy to read, follow and understand.


## INSTALLATION

inside the backend application run :
`install-package Microsoft.EntityFrameWorkcore.SqlServer`
`install-package Microsoft.EntityFrameWorkcore.Tools`
(downloads the entity framework core for this repository and allows us to use a SQL server and its tools.)

Add a new database connection and pass in its connection string inside `SQL` in appsettings.
run the following commands when it's done
`add-migration '(name)'`
`update-database`

Now you will need to hardcode values to the table Products and the tables Categories.
Once that is done you can now run the backend-API and wait for it to load, simultaneously in the vscode frontend project, you can run `npm start`.
Which runs the app in the development mode.
Open [http://localhost:3000]to view it in your browser.


:sparkles: Now your API should be running and in frontend you should be able to see the products displayed from your backendAPI.