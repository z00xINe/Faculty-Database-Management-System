# Faculty Database Management System

## Overview
A C# console application designed to manage faculty records within an academic institution. The system provides core data management functionality including creation, reading, updating, and deletion (CRUD) of faculty information with file-based persistence. Built with object-oriented principles, the application demonstrates structured data handling, input validation, and modular console interface design.

## Features
- **CRUD Operations**: Full support for adding, viewing, updating, and removing faculty records
- **Data Persistence**: Stores faculty data in structured text or JSON files for retention between sessions [[9]]
- **Search and Filter**: Query faculty by name, ID, department, or other attributes
- **Input Validation**: Ensures data integrity through formatted input checks and error handling
- **Menu-Driven Interface**: Intuitive console navigation with numbered options and clear prompts
- **Structured Output**: Formatted display of faculty records with aligned columns and readable layout
- **Error Handling**: Graceful management of file I/O exceptions and invalid user input [[13]]

## Technologies Used
- Language: C# (100%)
- Framework: .NET Console Application
- Data Storage: File-based persistence using System.IO namespace [[12]]
- Standard Libraries: System, System.Collections.Generic, System.IO, System.Linq
- IDE Compatibility: Visual Studio, Visual Studio Code, or any .NET-compatible editor

## Project Structure

```
Faculty-DataBase/
├── FacultyManagementSystem.sln # Visual Studio solution file
├── FacultyManagementSystem/ # Main project directory
│ ├── Program.cs # Application entry point and menu logic
│ ├── Faculty.cs # Faculty entity class definition
│ ├── FacultyManager.cs # Business logic for CRUD operations
│ ├── FileHandler.cs # File I/O utilities for data persistence
│ └── Utilities.cs # Helper methods for validation and formatting
├── .gitignore # Git ignore rules
└── .gitattributes # Git attribute configuration
```


## Setup and Usage
1. Clone the repository:
```bash
git clone https://github.com/z00xINe/Faculty-DataBase.git
cd Faculty-DataBase
```
2. Open the solution in Visual Studio or build via .NET CLI:
```
dotnet build FacultyManagementSystem.sln
```
3. Run the application:
```
dotnet run --project FacultyManagementSystem
```
4. Follow the interactive console menu:
  - Add new faculty member with required fields (ID, Name, Department, Title, Contact)
  - View all records or search by specific criteria
  - Update existing faculty information
  - Delete records with confirmation prompt
  - Export data to file or reload from persistent storage

## Data Format Example

- Faculty records are stored in a structured format such as:
```
ID: F1001
Name: Dr. Sarah Johnson
Department: Computer Science
Title: Associate Professor
Email: s.johnson@university.edu
Phone: +1-555-0123
HireDate: 2019-08-15
---
```

## Extensibility Notes

- Modular class design allows easy addition of new fields or validation rules
- FileHandler abstraction supports migration to database backends (SQL Server, SQLite) 
- Console interface can be adapted to Windows Forms or WPF for GUI deployment 
- LINQ queries enable flexible filtering and sorting without code duplication 

## Notes

- This project is intended for educational purposes to demonstrate C# console application architecture and file-based data management 
- Input files must follow the expected schema to ensure correct parsing
- For production use, consider adding authentication, audit logging, and concurrent access safeguards
