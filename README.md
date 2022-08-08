# _Factory_

#### By _**Peter Vang**_

#### A simple C# Many-to-Many Independent project.

## Technologies Used

* Git
* C#
* .NET 6.0
* ASP.NET
* RESTful Routing
* Entity Framework Core
* MVC
* BootStrap
* MySQL Workbench
* Razor view Engine  

## Description

_This is a C# MVC application to keep track of Dr. Sillystringz machine repairs from license engineers. This application helps input the new engineers and machines. It also helps signing license engineers to their machines that they can fix._

## Setup/Installation Requirements

* _Open your terminal_
* _Clone this project with the following commands $ git clone https://github.com/vangpeter06/Factory.Solution
* _Navigate to the directory in terminal $ cd Factory.Solution_
* _Open project in the command $ code ._
* _Navigate to the sub-directory of the project $ cd Factory_
* _Add appsettings.json file to the Factory directory in terminal $ touch appsettings.json_
* _Insert the following codes 
  {
   "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=peter_vang;uid=[YOUR-USERID-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }_
* _Once appsettings.json file has been created, navigate nack to SQL Workbench_
* _Import the database name peter_vang from the root diectory of the project.
* _How to Import a Database_
* _Open SQL Workbench._
* _Navigate to "Administration" tab in SQL Workbench._
* _Click "Data Import/Restore"._
* _Select the radio button "Import from Self-Contained File" and include file path to the sql file of this project you cloned to your machine._
* _In "Default Schema to be Imported to" click "New"._
* _Name the schema "Factory" then click "OK"._
* _Once named, switch to "Import Progress" tab and click "Start Import"._
* _Here is more information how to import database._
  (here is the website how to import https://www.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench)
8 _Navigate to HairSalon directory_
* _Restore and install packages listed in the csproj in the command $ dotnet restore_
* _Build your dependencies in your command $ dotnet build_
* _Next we will execute this compiled code in command $ dotnet run_

## Known Bugs

no know bug

## License

_If you run into any issues or have questions, ideas or concerns please contact the authors or make a contribution to the code._

This software is licensed under the MIT license

Copyright (c) _8/7/2022_ _Peter Vang_    