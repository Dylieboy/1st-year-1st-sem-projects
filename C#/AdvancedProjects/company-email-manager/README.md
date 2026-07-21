# Company Email Address Manager

A C# Console Application that generates and manages company email addresses for employees using arrays and a menu-driven interface.

---

## Features

- Add new employee email addresses
- Automatically generate company email addresses
- View all stored email addresses
- Delete email addresses
- Menu-driven console interface
- Input validation
- Prevents empty names from being entered

---

## Email Format

The application automatically creates email addresses using:

```
firstname + surname + @jdl.co.za
```

### Example

| First Name | Surname | Generated Email |
|------------|---------|-----------------|
| John | Smith | johnsmith@jdl.co.za |
| Sarah | Jones | sarahjones@jdl.co.za |
| Dylan | Fivaz | dylanfivaz@jdl.co.za |

---

## Example

### Menu

```
=================================
 COMPANY EMAIL ADDRESS MANAGER
=================================

1. Add New Address
2. Delete Address
3. View Addresses
0. Exit
```

### Example Output

```
Enter First Name: John
Enter Surname: Smith

Created:
johnsmith@jdl.co.za
```

---

## Concepts Demonstrated

- Arrays
- Methods
- Menu-driven programming
- Switch statements
- Loops
- String manipulation
- Input validation
- CRUD operations (Create, Read, Delete)

---

## Requirements

- .NET SDK
- Visual Studio 2022

---

## How to Run

1. Open the project in Visual Studio.
2. Build the solution.
3. Run the application.
4. Choose an option from the menu.
5. Add, view, or delete company email addresses.

---

## Learning Objectives

This project demonstrates how to:

- Store data using arrays.
- Generate email addresses using string manipulation.
- Build a menu-driven console application.
- Separate functionality into reusable methods.
- Validate user input.

---