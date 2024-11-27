using System.Runtime.CompilerServices;

class Vehicle { // parent class if you dont want this class to be inherit by other use can use sealed keyword before declarig class name
    public string brand = "Ford";

    public void printSomething() {
        Console.WriteLine($"The car I drive is of a {brand}");
    }

    public void printSomething1() {
        Console.WriteLine($"The car I drive is of a {brand}");
    }
    
}