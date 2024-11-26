// See https://aka.ms/new-console-template for more information


/*
What is OOP?
OOP: Object Oriented programming
OOP: 
1. OOP is fater and easier to execute 
2. clear structure 
3. Reusing 

Classes: Car
Object: ford, honda, toyata


Constructors:
A costructor is a specific methodf that is used to initalized object. It will initalize as soon as we create an object of an class.


*/
using System.Runtime.InteropServices;

class Program {
    private string car;

    /*
    * Constructor with no parm
    */
    public Program(string carName) {
        car = carName;
    }
    static void Main(string[] args) {
        Program program = new Program("Red");  //Object 
        Console.WriteLine(program.car);
        Program program1 = new Program("Ford");
        Console.WriteLine(program1.car);

        program.myMethod("Abhi");
        program1.myMethod("Patel");

        Car car = new Car();
        Console.WriteLine(car.company);
    }

    public void myMethod(string someName) {
        Console.WriteLine($"Value of car is {car}");
        Console.WriteLine("The name is: " + someName);
    }

    private void test() {

    }

}

class Car {
    public string company = "Honda";
    string abc = "abc"; //private
}

/*
Any one whio create an object of an class they can invoke any public method.
*/


/*
Access Modifiers:
public, private, protected, internal

Assign on classes, field, method and properties

public: The code is accessible for all classes
private: The code is only accessible within classes 
*/