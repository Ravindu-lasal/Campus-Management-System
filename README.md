# <h1 align="center" id="title">Campus Management System</h1>

![GitHub language count](https://img.shields.io/github/languages/count/Ravindu-lasal/Campus-Management-System)




The **Campus Management System** is a C# application designed to efficiently manage student and teacher details within an educational institution. The system allows administrators to store, update, and retrieve information related to students and teachers, ensuring smooth campus operations.

The application is developed using **C#** for the frontend and connects to a **MySQL Workbench** database for secure and structured data management. Users can perform CRUD (Create, Read, Update, Delete) operations on student and teacher records, making it easy to maintain academic and administrative details.

<h2>Project Screenshots:</h2>

<img src="https://github.com/Ravindu-lasal/Campus-Management-System/blob/d58f692a521ca5825487d18f35a7bd9da26de65b/Screenshot/cms1.png" alt="project-screenshot" width="597" height="400/">
<img src="https://github.com/Ravindu-lasal/Campus-Management-System/blob/d58f692a521ca5825487d18f35a7bd9da26de65b/Screenshot/cms2.png" alt="project-screenshot" width="1000" height="560/">
<img src="https://github.com/Ravindu-lasal/Campus-Management-System/blob/d58f692a521ca5825487d18f35a7bd9da26de65b/Screenshot/cms3.png" alt="project-screenshot" width="1000" height="560/">
<img src="https://github.com/Ravindu-lasal/Campus-Management-System/blob/d58f692a521ca5825487d18f35a7bd9da26de65b/Screenshot/cms4.png" alt="project-screenshot" width="1000" height="560/">

  
  
<h2>🧐 Features</h2>

Here're some of the project's best features:

*   Student and teacher registration
*   Data retrieval and modification
*   Secure database connection with MySQL Workbench
*   User-friendly interface for easy navigation


<h2>🛠️ Installation Steps:</h2>

<p>1. Install Required Software</p>

```
Visual Studio (with .NET support)  MySQL Workbench
```


<p>2. Configure the Database</p>

*    Open MySQL Workbench and create a new database.
*    Import the provided .sql file to create necessary tables:
```
campus.sql
```
*    Go to File > Open SQL Script and select the .sql file.
*    Click Execute to run the script.
*    Update your database connection settings in All form
  
```
 public string connString = "Server=localhost;Database=campus;User ID=root;Password=yourpassword;SslMode=none;";
```

  
  
<h2>💻 Built with</h2>

Technologies used in the project:

*   Visual Studio
*   MySQL Workbench
*   C#


---
