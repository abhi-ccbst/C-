using System.Reflection.Metadata.Ecma335;

abstract class Vehicle {
    private string make;

    public string Make {
        get {
            return make;
        }
        set {
            make = value;
        }

    }

    public string Model {get; set;}
    public int Year {get; set;}

    public abstract void display();
    public void displayBanner() {
        Console.WriteLine("######################\n\tVehcile");
        Console.WriteLine($"Make:\t{Make}\nModel:\t{Model}\nYear:\t{Year}");
    }

    public Vehicle(string make, string model, int year) {
        Make = make;
        Model = model;
        Year = year;
    }

}