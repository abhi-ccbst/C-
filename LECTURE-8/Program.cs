// using System;

// namespace ComprehensiveCSharpProject
// {
//     // Interface for performing math operations
//     interface IMathOperations
//     {
//         double Add(double a, double b);
//         double Subtract(double a, double b);
//         double Multiply(double a, double b);
//         double Divide(double a, double b);
//     }

//     // Abstract class for a basic mathematical calculator
//     abstract class Calculator : IMathOperations
//     {
//         public abstract double Add(double a, double b);
//         public abstract double Subtract(double a, double b);
//         public abstract double Multiply(double a, double b);
//         public abstract double Divide(double a, double b);

//         public double Power(double baseValue, double exponent)
//         {
//             return Math.Pow(baseValue, exponent);
//         }

//         public double Sqrt(double number)
//         {
//             return Math.Sqrt(number);
//         }
//     }

//     // Derived class implementing Calculator
//     class SimpleCalculator : Calculator
//     {
//         public override double Add(double a, double b)
//         {
//             return a + b;
//         }

//         public override double Subtract(double a, double b)
//         {
//             return a - b;
//         }

//         public override double Multiply(double a, double b)
//         {
//             return a * b;
//         }

//         public override double Divide(double a, double b)
//         {
//             if (b != 0)
//                 return a / b;
//             else
//                 throw new DivideByZeroException("Cannot divide by zero.");
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Output example
//             Console.WriteLine("Welcome to the Comprehensive C# Program!");

//             // Variable and User Input
//             Console.Write("Please enter your name: ");
//             string userName = Console.ReadLine();

//             Console.WriteLine($"Hello, {userName}!");

//             // Type casting example
//             Console.Write("Enter an integer number: ");
//             string input = Console.ReadLine();
//             int userInt = Convert.ToInt32(input);
//             double userDouble = (double)userInt;  // Type casting int to double
//             Console.WriteLine($"Your integer as a double is: {userDouble}");

//             // Operators example
//             int a = 10, b = 5;
//             int addition = a + b;
//             int multiplication = a * b;
//             Console.WriteLine($"Addition: {addition}, Multiplication: {multiplication}");

//             // Math operations example
//             double sqrtValue = Math.Sqrt(16);
//             Console.WriteLine($"The square root of 16 is: {sqrtValue}");

//             // String operations example
//             string sentence = "C# is powerful!";
//             Console.WriteLine($"The length of the sentence: {sentence.Length}");
//             Console.WriteLine($"Uppercase sentence: {sentence.ToUpper()}");

//             // Conditional - If-Else
//             if (userInt > 0)
//             {
//                 Console.WriteLine("You entered a positive number!");
//             }
//             else if (userInt < 0)
//             {
//                 Console.WriteLine("You entered a negative number!");
//             }
//             else
//             {
//                 Console.WriteLine("You entered zero.");
//             }

//             // Switch case
//             Console.Write("Enter a number between 1 and 3: ");
//             int choice = Convert.ToInt32(Console.ReadLine());

//             switch (choice)
//             {
//                 case 1:
//                     Console.WriteLine("You chose option 1!");
//                     break;
//                 case 2:
//                     Console.WriteLine("You chose option 2!");
//                     break;
//                 case 3:
//                     Console.WriteLine("You chose option 3!");
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice.");
//                     break;
//             }

//             // Loops - While loop
//             int counter = 0;
//             while (counter < 5)
//             {
//                 Console.WriteLine($"While Loop - Counter: {counter}");
//                 counter++;
//             }

//             // Loops - For loop
//             for (int i = 0; i < 5; i++)
//             {
//                 Console.WriteLine($"For Loop - Iteration {i}");
//                 if (i == 3)
//                 {
//                     Console.WriteLine("Breaking the loop at iteration 3.");
//                     break; // Break when i equals 3
//                 }
//             }

//             // Continue in loop example
//             for (int i = 0; i < 5; i++)
//             {
//                 if (i == 2)
//                 {
//                     Console.WriteLine("Skipping iteration 2");
//                     continue; // Skip the rest of the loop for i == 2
//                 }
//                 Console.WriteLine($"For Loop - Skipping iteration 2: {i}");
//             }

//             // Array example
//             int[] numbers = { 10, 20, 30, 40, 50 };
//             Console.WriteLine($"Array Element at index 2: {numbers[2]}");

//             // Inheritance example - Using Calculator and SimpleCalculator
//             SimpleCalculator calc = new SimpleCalculator();

//             double addResult = calc.Add(10, 5);
//             double subResult = calc.Subtract(10, 5);
//             double mulResult = calc.Multiply(10, 5);
//             double divResult = calc.Divide(10, 5);

//             Console.WriteLine($"Addition: {addResult}, Subtraction: {subResult}, Multiplication: {mulResult}, Division: {divResult}");

//             // Using base() to call the Power method from abstract class
//             double powerResult = calc.Power(2, 3);
//             Console.WriteLine($"Power: 2 raised to 3 is {powerResult}");

//             // Using properties
//             string name = "Simple Calculator";
//             Console.WriteLine($"Calculator Name: {name}");

//             // Ending the program
//             Console.WriteLine("Press any key to exit...");
//             Console.ReadKey();
//         }
//     }
// }
