# _MVC Engineer/Machine Tracker_

#### _An MVC app to practice many-to-many relationships using Entity, 7/14/2020_

#### By _**Hannah Beinstein**_

## Description

This project is an program created to practice MVC web app design and many-to-many relationships. The program contains two classes, one for Engineers and one for Machines that they are responsible for repairing. The program can display a list of engineers and their associated machines, a list of machines and their associated engineers, and also includes functionality to add and remove both engineers and machines.

## Specs

| Spec | Input | Output |
| :-------------      | :------------- | :------------- |
| 1. Program will display an error message if no machines have been added to database | -- | "No machines have been added yet!" |
| 2. Program will display an error message if no engineers have been added to database | -- | "No engineers have been added yet!" |
| 3. Program will add new engineers to database | "add engineer" | "Lisa" |
| 4. Program will add new machines to database | "add machine" | "Dreamweaver" |
| 5. Program will display a list of all engineers | -- | "Lisa, Hannah, Michael, Betty" |
| 6. Program will display a list of all machines | -- | "Lisa, Hannah, Michael, Betty" |
| 7. Program will display a list of all machines belonging to an engineer | Engineer: "Lisa" | Machines: "Dreamweaver, Bubblewrappinator, Laughbox" |
| 8. Program will display a list of all engineers belonging to a machine | Machine: "Dreamweaver" | Engineers: "Lisa, Betty, Michael" |

## Setup/Installation Requirements

* _Clone or download this repository located at https://github.com/HBeinstein/HairSalon.Solution.
* _TO CREATE DATABASE: Run 
* _Run $ dotnet restore to download all dev dependencies._
* _Run $ dotnet build to create project._

## Known Bugs

_No known bugs_

## Support and contact details

_{Please contact me at hannah.beinstein@gmail.com with any known bugs or support issues.}_

## Technologies Used

* _C#_
* _SQL_
* _EFC_

### License

*Copyright (c) 2020 **_Hannah Beinstein MIT License_**