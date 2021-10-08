# Hair Salon

#### An application that allows the user to log hair stylists and their clients

#### Created By: Chynna Lew

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench

## Description

This application allows the user to create and store a list of hair stylists and each of their clients. This project was created for Epicodus bootcamp to show proficiency with one to many relationships in ASP.NET Core MVC, Entity Core Framework, and MySql.
* Project objectives:
  - Follow proper naming conventions
  - Create a one to many relationship within the database
  - CREATE functionality implemented for one class and CREATE and VEIW functionality implemented for the other class
  - Entity is used to communicate with the database
  - Allow the user to search for all of a cuisine's restaurants

## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

* Clone [this](https://github.com/chynnalew/HairSalon.Solution) repository, or download and open the Zip on your local machine
* Open the HairSalon.Solutions folder in your preferred text editor
* To install required packages, navigate to HairSalon.Solutions/HairSalon in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
* Create a file named "appsettings.json" in the HairSalon directory
  - add the following code to the appsettings.json file:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=chynna_lew;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }.
  ```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command "$ mySql -uroot -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required database:
  - Open MySql Workbench
  - Select your preferred server(default is root)
  - In the "Navigator > Administration" window, select "Data Import/ Restore"
  - In "Import Options", select "Import From Self-Contained File"
  - Navigate to "HairSalon.Solutions/chynna_lew.sql" in the search input
  - Under "Default Schema to be Imported to" select the "New" button
  - Enter "chynna_lew" and click "OK"
  - Navigate to the "Import Progress" tab and click "Start Import" in the bottom right corner of the window
  - Reopen the "Navigator>Schemas" tab, Right click and select "refresh all" to see the imported database
* To Restore, build, and run the project:
  - Navigate to the HairSalon.Solutions/HairSalon folder in the command line or terminal
    - Run the command "$ dotnet restore" to restore the project dependencies
    - Run the command "$ dotnet build" to build and compile the project
    - Run the command "$ dotnet run" to build and compile the project

## Known Bugs

* The edit functionality is not working for Stylists. The path link in HairSalon/Stylists/Details.cshtml has been commented out to ensure page functionality.

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Chynna Lew

## Support and contact details

* [Chynna Lew](github.com/chynnalew) 
* <ChynnaLew@yahoo.com>