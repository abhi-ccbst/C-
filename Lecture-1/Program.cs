// // See https://aka.ms/new-console-template for more information
// using System.Runtime.InteropServices.Marshalling;

// Console.WriteLine("Hello, World!");

// Console.WriteLine("Hello, From Abhi!");

// // This is a comment

// /* This is 
//  Test 
//  Test2 
//  */
// Console.Write("Hello World from Write()");
// Console.Write("Hello From Abhi P!");
// Console.WriteLine();
// /* 
// Types of variable
// 1. String: stores text, such as "Abhi Patel". String values surrounded by double quotes
// 2. int: stores integers, without decimals, such as 123 or -123. Size: 4 bytes. -2,147,483,648 to 2,147,483,647
// 3. float: decimal value. 4 bytes. 6 decimal point. 
// 3. long: 8 bytes.  -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
// 3. double: stores floating point numbers, with de imals such as 123.123 or -123.321. Size: 8 bytes. 15 decimal point. 
// 4. bool: stores values with 2 states: true and false
// 5. Char: stores single characters, such as 'A'. Char values are surrounded by single quotes
// */

// /*
// ############## Variable and Data Types
// */
// // Console.WriteLine();
// // string name = "Abhi P";  //Decl.. && initalized
// // Console.WriteLine("Hello From " + name +" !");


// // int age = 23;
// // Console.WriteLine(age);

// // int y = 5;
// // Console.WriteLine(age * y);

// // long myNum = 123L;
// // Console.WriteLine("This is my number: " + myNum);

// // float myFoatNum = 123.456F;
// // Console.WriteLine("This is mu float num: "+ myFoatNum);


// // double marks = 23.21;
// // Console.WriteLine(marks);

// // bool pass = true;
// // Console.WriteLine(pass);

// // char singleChar = 'A';
// // Console.WriteLine(singleChar);

// // const string firstName = "Abhi";
// // Console.WriteLine(firstName);
// // Console.WriteLine(name + firstName);
// //firstName = "Test"; //error

// /*
// ###################### User Input
// */
// // Console.WriteLine("Please enter your name: ");
// // string fullName = Console.ReadLine();

// // Console.WriteLine("Your name is: " + fullName);

// // Console.WriteLine("Please enter you age");
// // String ageString = Console.ReadLine();
// // int ageInt = Convert.ToInt32(ageString);
// // Console.WriteLine("Your age is: " + ageInt);


// /*
// ############## Type Casting 
// 2 way: 
// 1. Implict (automatically): convertinf smaller type -> larger type size..
// char -> int -> long -> float -> double
// 2. Explict (manually): convertinf from larger value to smaller aize type.... 
// double -> float -> long -> int -> char
// */

// // int myInt = 9;
// // double myDouble = myInt;
// // Console.WriteLine("MyInt is: " + myInt + " MyDouble is: " + myDouble);

// // myDouble = 9.123;
// // myInt = (int) myDouble;
// // Console.WriteLine("MyInt is: " + myInt + " MyDouble is: " + myDouble);

// // /*
// // Type Casting using methods
// // */

// // myInt = 10;
// // myDouble = 5.25;
// // bool myBool = true;
// // string te = Convert.ToString(myInt);
// // Console.WriteLine(Convert.ToString(myInt));  // convert int to string
// // Convert.ToDouble(myInt);
// // Convert.ToInt32(myBool);
// // Convert.ToInt64(myDouble);

// /*
// Arithemtic Operations: 
// + ex: x + y
// - ex: x-y
// * ex: x * y
// / ex: x / y
// % (Modulus) Return the divison remainder x % y
// ++ Increment x++
// -- Decrement y--
// */
// int x = 10;
// int y = 5;

// Console.WriteLine(x * y);
// Console.WriteLine(x % y);
// x++;   //x = x+1;
// Console.WriteLine(x);
// Console.WriteLine(x * y);

// x--;     // x = x-1;
// Console.WriteLine(x);
// Console.WriteLine(x * y);


// /*
// +=     x +=3     x = x + 3
// -=     x -= 3    x = x - 3
// *=     x *= 3    x = x * 3
// /=     x /= 3    x = x / 3
// %=     x %= 3    x = x % 3
// */

// /*
// ###       Comparison
// */

// // x = y; //Assign value from Y to X
// // x == y; // Comparision
// Console.WriteLine(x == y);

// // != (opp of ==)
// Console.WriteLine(x != y);
// // x = 5;
// // y = 5;
// Console.WriteLine(x < y);

// Console.WriteLine(x <= y);

// // And: Both condition needs to be true (&&)
// // OR: One of the condition needs to be true (||)

// Console.WriteLine(x>y && x <y);
// Console.WriteLine(x>y || x <y);


using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

Console.WriteLine("This is an print statement");
int x = 8;
const int y = 5;

Console.WriteLine("The value of X: " +x +" and Y: "+ y);
Console.WriteLine("Enter you name: ");
string name = Console.ReadLine();

Console.WriteLine("The name you enter is: "+ name);

Console.WriteLine("Enter you age: ");
string ageString = Console.ReadLine();
int age = Convert.ToInt32(ageString);

Console.WriteLine("The age you enter is: "+ age);

x += 2; // x = x +2
Console.WriteLine("The value of x: "+x+"and y: "+y); // x = 10 & y = 5
Console.WriteLine("The X > y : " + (x > y)); //True 

Console.WriteLine("The x > y && x >= y: " + (x > y && x >= y)); //True 

/* 
String
1. txt.Length: it will return the size of text
2. ToUpper(): Conert to upper case
3. ToLower(): Convert to lower case
4. string.Concat
*/
string firstName = "Abhi";
int len = firstName.Length;
Console.WriteLine("The length of firstName varible is: " +firstName.Length); 
Console.WriteLine("The Upper case: " + firstName.ToUpper());
Console.WriteLine("The lower case: " + firstName.ToLower());


/*
first last
fullName
*/
// Option: 1
string lastName = "Patel";
string fullName = firstName + " " +lastName;  //concatenation

Console.WriteLine("My full name is: " + fullName);

// Option; 2
// string.Concat()
fullName = string.Concat(firstName, " ",lastName);
Console.WriteLine("My full name is: " + fullName +". Using method 2");



/*
Interpolation
*/
fullName = $"{firstName} {lastName}";
string info = $"If you believe this key {firstName} was added in error.{lastName}";
Console.WriteLine(info);