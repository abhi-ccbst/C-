// using System;

// // Interface that defines behavior for animals
// public interface IAnimal
// {
//     void MakeSound();   // All animals must make a sound
//     void Eat();         // All animals must eat
// }

// // Abstract class that provides some common functionality for all animals
// public abstract class Animal : IAnimal
// {
//     // Property common to all animals
//     public string Name { get; set; }

//     // Constructor
//     public Animal(string name)
//     {
//         Name = name;
//     }

//     // Method that must be implemented by derived classes (abstract method)
//     public abstract void MakeSound();

//     // Method that is common to all animals (provides implementation)
//     public void Eat()
//     {
//         Console.WriteLine($"{Name} is eating.");
//     }

//     // Method to display animal info (optional for each animal, but can be overridden)
//     public virtual void ShowInfo()
//     {
//         Console.WriteLine($"This is {Name}, an animal.");
//     }
// }

// // Dog class that inherits from Animal
// public class Dog : Animal
// {
//     public Dog(string name) : base(name) { }

//     // Override the MakeSound method from Animal (specific to Dog)
//     public override void MakeSound()
//     {
//         Console.WriteLine($"{Name} barks: Woof!");
//     }

//     // Override ShowInfo to provide more specific details for Dog
//     public override void ShowInfo()
//     {
//         Console.WriteLine($"{Name} is a dog.");
//     }
// }

// // Cat class that inherits from Animal
// public class Cat : Animal
// {
//     public Cat(string name) : base(name) { }

//     // Override the MakeSound method from Animal (specific to Cat)
//     public override void MakeSound()
//     {
//         Console.WriteLine($"{Name} meows: Meow!");
//     }

//     // Override ShowInfo to provide more specific details for Cat
//     public override void ShowInfo()
//     {
//         Console.WriteLine($"{Name} is a cat.");
//     }
// }

// // Main program to demonstrate abstract classes, interfaces, and inheritance
// class Program
// {
//     static void ain()
//     {
//         // Create instances of Dog and Cat
//         Animal dog = new Dog("Buddy");
//         Animal cat = new Cat("Whiskers");

//         // Call methods on Dog
//         dog.MakeSound();  // Should print "Buddy barks: Woof!"
//         dog.Eat();        // Should print "Buddy is eating."
//         dog.ShowInfo();   // Should print "Buddy is a dog."

//         Console.WriteLine();

//         // Call methods on Cat
//         cat.MakeSound();  // Should print "Whiskers meows: Meow!"
//         cat.Eat();        // Should print "Whiskers is eating."
//         cat.ShowInfo();   // Should print "Whiskers is a cat."
//     }
// }
