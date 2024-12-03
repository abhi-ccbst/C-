using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

public interface LivingBeing {
    void MakeSound();
    void Eat();
}

abstract class Animal : LivingBeing {
    public string Name { get; set; }

    public string FoodName { get; set; }
    public Animal(String name, String foodName) {
        Name = name;
        FoodName = foodName;
    }

    public abstract void MakeSound();

    public void Eat() {
        Console.WriteLine($"{Name} is eating {FoodName}");
    }

    public virtual void ShowInfo() {
        Console.WriteLine($"This is {Name}, an animal");
    }

    public abstract void ShowBread();
}

class Cow : Animal {

    public String Bread {get; set;}
    public Cow(string name, string foodName, string bread) : base(name, foodName) {
        Bread = bread;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} sound: Moo");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{Name} is a cow");
    }

    public override void ShowBread() {
        Console.WriteLine($"Cow Bread: {Bread}");
    }
}

class Cat : Animal
{
    public String Bread {get; set;}
    public Cat(string name, string foodName, string bread) : base(name, foodName) {
        Bread = bread;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} sound: Meow");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"{Name} is a cat");
    }

    public override void ShowBread() {
        Console.WriteLine($"Cat Bread: {Bread}");
    }
}

class InClass {
    static void Main(string[] args) {
        Animal cow = new Cow("Buddy", "grass", "Sahiwal");
        cow.MakeSound();
        cow.Eat();
        cow.ShowInfo();
        cow.ShowBread();

        Animal cat = new Cat("Tom", "milk", "dfjkgj");
        cat.MakeSound();
        cat.Eat();
        cat.ShowInfo();
        cat.ShowBread();

    }
}