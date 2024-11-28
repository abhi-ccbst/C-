// class Program {
//     static void Main(string[] args) {
//         // Car car = new Car();
//         // car.print();
//         // car.name();

//         Ford ford = new Ford();
//         //ford.print();
//         ford.name();
//         ford.carPrice();

//         Honda honda = new Honda();
//         //honda.print();
//         honda.name();
//         honda.carPrice();

//         Car fordCar = new Ford();
//         //fordCar.print();
//         fordCar.name();
//         //fordCar.carPrice();
//     }
// }


// Polymorphism
//virtual keyword to the method inside te base class and override keyword for each derived class then it work as we asumed



using System;

class Vehicle {
    private string make;
    private string model;
    private int year; // Correct type for the backing field

    public string Make {
        get { return make; }
        set { make = value; }
    }

    public string Model {
        get { return model; }
        set { model = value; }
    }

    public int Year {
        get { return year; }
        set { year = value; }
    }

    // Example constructor
    public Vehicle(string make, string model, int year) {
        Make = make;
        Model = model;
        Year = year;
    }

    // Example method
    public void DisplayInfo() {
        Console.WriteLine($"Vehicle Info: {Year} {Make} {Model}");
    }
    public virtual void Start() {
        Console.WriteLine("The vehicle is starting...");
    }
}


class Car : Vehicle {
    public int NumberOfDoors { get; set; }

    public Car(string make, string model, int year, int numberOfDoors)
        : base(make, model, year) {
        NumberOfDoors = numberOfDoors;
    }

    public override void Start() {
        Console.WriteLine($"The car ({Make} {Model}) is starting...");
    }

    public void OpenTrunk() {
        Console.WriteLine("The trunk is open.");
    }
}

class Motorcycle : Vehicle {
    public bool HasSidecar { get; set; }

    public Motorcycle(string make, string model, int year, bool hasSidecar)
        : base(make, model, year) {
        HasSidecar = hasSidecar;
    }

    public override void Start() {
        Console.WriteLine($"The motorcycle ({Make} {Model}) is starting...");
    }

    public void PopWheelie() {
        Console.WriteLine("The motorcycle is popping a wheelie!");
    }
}

class Program {
    static void Main(string[] args) {
        // Create a Car instance
        Car myCar = new Car("Toyota", "Camry", 2020, 4);
        myCar.DisplayInfo();
        myCar.Start();
        myCar.OpenTrunk();
        Console.WriteLine();

        // Create a Motorcycle instance
        Motorcycle myMotorcycle = new Motorcycle("Harley-Davidson", "Street 750", 2019, false);
        myMotorcycle.DisplayInfo();
        myMotorcycle.Start();
        myMotorcycle.PopWheelie();
    }
}
