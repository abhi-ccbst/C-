// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Runtime.CompilerServices;

class Program {
    static void Main(string[] args) {
       Add(2, 3);
       Sub(15, 9);
       Sub(15);
       int mul = Mul(2, 5);
       Console.WriteLine($"The multiplication of this {2} and {5} is {mul}");

       printNames(fullName: "Abhi Patel", lastName: "Patel", firstName: "Abhi");
    }
    static void MyTestMethod() {
        Console.WriteLine("I am running from Main method");
    }

    /**
    * This method is taking 2 arg and doing addition operation on this
    * @param a int
    * @param b int
    */
    static void Add(int a, int b) {
        Console.WriteLine($"The addition of this {a} and {b} is {a+b}" );
    }

    /**
    * This method is taking 2 arg and doing substraction operation on this
    * @param a int
    * @param b int
    */
    static void Sub(int a, int b = 10){
        Console.WriteLine($"The substraction of this {a} and {b} is {a-b}");
    }


    /**
    * This method is taking 2 arg and doing substraction operation on this
    * @param a int
    * @param b int
    * @return int
    */
    static int Mul(int a, int b = 1) {
        int mul = a * b;
        return mul;
    }
    //Method is overloading
    //Mutiple methods can have the same name with different parameters is known as Overloading. 
    static int Mul(int a) {
        return 0;
    }

    // Named Arguments 
    static void printNames(string firstName, string lastName, string fullName) {
        Console.WriteLine($"My First Name is {firstName}");
        Console.WriteLine($"My Last Name is {lastName}");
        Console.WriteLine($"My Full Name is {fullName}");
    }
}


/*
void: means nothing to be return
instead of void if there is any different value like: int, double .........

*/