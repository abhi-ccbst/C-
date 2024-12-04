
// C# Assignment: Implementing OOP Concepts with Enum
// Title: Employee Management System
// Objective:
// The purpose of this assignment is to help students understand and implement Object-Oriented Programming (OOP) concepts such as encapsulation, inheritance, polymorphism, and the use of enums in C#.

// Assignment Instructions:
// You are tasked with creating a simple Employee Management System using C# that:

// Categorizes employees based on their department using an enum.
// Demonstrates OOP principles, including:
// Encapsulation
// Inheritance
// Polymorphism
// Requirements:
// Enum:
// Create an enum called Department with the following values:

// HR
// IT
// Finance
// Marketing
// Classes and Inheritance:

// Create a base class Employee with the following properties:

// Id (int)
// Name (string)
// Department (enum)
// Salary (decimal)
// Create a constructor to initialize these properties.

// Add a virtual method GetDetails() that returns a string with the employee's details.

// Create two derived classes:

// Manager
// Developer
// Each derived class should override the GetDetails() method to add specific details about their role.

// Polymorphism:
// Use polymorphism to store instances of both Manager and Developer in a list and iterate through the list to print their details.

// Main Method:

// Prompt the user to enter details for at least two employees (one Manager and one Developer).
// Add the employees to a list and display their details using the GetDetails() method.



// OUTPUT
// Enter details for Manager:  
// Id: 1  
// Name: Alice  
// Department (HR, IT, Finance, Marketing): HR  :: Enum.Parse(typerof(Department), Console.ReadLine())
// Salary: 80000  

// Enter details for Developer:  
// Id: 2  
// Name: Bob  
// Department (IT, HR, Finance, Marketing): IT  
// Salary: 60000  

// Employee Details:  
// Id: 1, Name: Alice, Department: HR, Role: Manager, Salary: $80,000  
// Id: 2, Name: Bob, Department: IT, Role: Developer, Salary: $60,000  
