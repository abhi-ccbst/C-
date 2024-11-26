// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Xml.Serialization;

class Program {
    // static void Main(string[] args) {
    //    Add(2, 3);
    //    Sub(15, 9);
    //    Sub(15);
    //    int mul = Mul(2, 5);
    //    Console.WriteLine($"The multiplication of this {2} and {5} is {mul}");

    //    printNames(fullName: "Abhi Patel", lastName: "Patel", firstName: "Abhi");
    // }
    // static void MyTestMethod() {
    //     Console.WriteLine("I am running from Main method");
    // }

    // /**
    // * This method is taking 2 arg and doing addition operation on this
    // * @param a int
    // * @param b int
    // */
    // static void Add(int a, int b) {
    //     Console.WriteLine($"The addition of this {a} and {b} is {a+b}" );
    // }

    // /**
    // * This method is taking 2 arg and doing substraction operation on this
    // * @param a int
    // * @param b int
    // */
    // static void Sub(int a, int b = 10){
    //     Console.WriteLine($"The substraction of this {a} and {b} is {a-b}");
    // }


    // /**
    // * This method is taking 2 arg and doing substraction operation on this
    // * @param a int
    // * @param b int
    // * @return int
    // */
    // static int Mul(int a, int b = 1) {
    //     int mul = a * b;
    //     return mul;
    // }
    // //Method is overloading
    // //Mutiple methods can have the same name with different parameters is known as Overloading. 
    // static int Mul(int a) {
    //     return 0;
    // }

    // // Named Arguments 
    // static void printNames(string firstName, string lastName, string fullName) {
    //     Console.WriteLine($"My First Name is {firstName}");
    //     Console.WriteLine($"My Last Name is {lastName}");
    //     Console.WriteLine($"My Full Name is {fullName}");
    // }

    // static void Main(string[] args) {

    //     bool userInput = true;
    //     do {
    //         Console.Write("Enter first number: ");
    //         int num1 = int.Parse(Console.ReadLine());

    //         Console.Write("Enter second number: ");
    //         int num2 = int.Parse(Console.ReadLine());
            
    //         Console.Write("Enter symbol(/,+,-,*): ");
    //         char operation = char.Parse(Console.ReadLine());

    //         switch (operation) {
    //             case '+': 
    //                 Console.WriteLine($"Add: {Add(num1, num2)}");
    //                 break;
    //             case '-':
    //                 Console.WriteLine($"Sub: {Sub(num1, num2)}");
    //                 break;    
    //             case '*':
    //                 Console.WriteLine($"Mul: {Mul(num1, num2)}");
    //                 break;   
    //             case '/':
    //                 Console.WriteLine($"Div: {Div(num1, num2)}");
    //                 break;  
    //             default: 
    //                 Console.WriteLine("Wrong input");
    //                 break;
    //         }

    //         Console.Write("Do you want to continue(y/n): ");
    //         char con = char.Parse(Console.ReadLine());
    //         if (con != 'y' && con != 'Y') {
    //             userInput = false;
    //         }
    //         Console.WriteLine("\n");
    //     } while(userInput);
    // }

    /**
    * This method is taking 2 arg and doing addition operation on this
    * @param a int
    * @param b int
    * @return int
    */
    static int Add(int a, int b) {
        return a +b;
    }

    /**
    * This method is taking 2 arg and doing sub operation on this
    * @param a int
    * @param b int
    * @return int
    */
    static int Sub(int a, int b) {
        return a - b;
    }

    /**
    * This method is taking 2 arg and doing mul operation on this
    * @param a int
    * @param b int    
    * @return int
    */
    static int Mul(int a, int b) {
        return a * b;
    }

    /**
    * This method is taking 2 arg and doing div operation on this
    * @param a int
    * @param b int    
    * @return int
    */
    static int Div(int a, int b) {
        return a / b;
    }


    // static void Main(string[] args) {
    //     bool userInput = true;
    //     do {
    //         Console.Write("Enter the first string: ");
    //         string str1 = Console.ReadLine();

    //         Console.Write("Enter the second string: ");
    //         string str2 = Console.ReadLine();
            
    //         Console.WriteLine("Choose an operation:");
    //         Console.WriteLine("1: Concatenate");
    //         Console.WriteLine("2: Find Length");
    //         Console.WriteLine("3: Reverse");
    //         Console.WriteLine("4: Check if second string is a substring of the first");
    //         Console.Write("Enter your choice (1/2/3/4): ");
    //         int choice = int.Parse(Console.ReadLine());

    //         switch (choice) {
    //             case 1: 
    //                 Console.WriteLine($"Concatenated String: {Concatenate(str1, str2)}");
    //                 break;
    //             case 2:
    //                 Console.WriteLine($"Length of First String: {GetLength(str1)}");
    //                 Console.WriteLine($"Length of Second String: {GetLength(str2)}");
    //                 break;    
    //             case 3:
    //                 Console.WriteLine($"Reversed First String: {ReverseString(str1)}");
    //                 Console.WriteLine($"Reversed Second String: {ReverseString(str2)}");
    //                 break;   
    //             case 4:
    //                 Console.WriteLine($"Is Second String a Substring of First? {IsSubstring(str1, str2)}");
    //                 break;  
    //             default: 
    //                 Console.WriteLine("Wrong input");
    //                 break;
    //         }

    //         Console.Write("Do you want to continue (y/n): ");
    //         char con = char.Parse(Console.ReadLine());
    //         if (con != 'y' && con != 'Y') {
    //             userInput = false;
    //         }
    //         Console.WriteLine("\n");
    //     } while(userInput);
    // }

    // Method to concatenate two strings
    static string Concatenate(string a, string b) {
        return $"{a}{b}";
    }

    // Method to get the length of a string
    static int GetLength(string str) {
        return str.Length;
    }

    // Method to reverse a string
    static string ReverseString(string str) {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Method to check if one string is a substring of another
    static bool IsSubstring(string a, string b) {
        return a.Contains(b);
    }



    static void Main(string[] args) {
        Console.WriteLine("Enter the number of row you want: ");
        int row =  int.Parse(Console.ReadLine()); // int row = 8;
        int count = row -1;
        for (int i =1; i <= row; i++) {
            for (int j = 1; j <= count; j++) {
                Console.Write(" ");
            }
            count--;
            for(int j = 1; j <= 2 * i -1; j++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        count = 1;
        for (int i = 1; i <= row -1; i ++) {
            for(int j = 1; j <= count; j++) {
                Console.Write(" ");
            }
            count++;
            for(int j = 1; j <= 2 * (row - i) - 1; j ++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}

// Old num: 2 * i -1
// Even num : 2 * i 



/*
void: means nothing to be return
instead of void if there is any different value like: int, double .........

*/