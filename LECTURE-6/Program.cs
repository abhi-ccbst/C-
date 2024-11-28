using System.Reflection.Metadata;

class Program {
    static void Main(string[] agrs) {
        Vehicle car = new Car("Ford", "SE", 2013, "Fusion");
        car.displayBanner();
        car.display();

        Vehicle moterCycle = new MoterCycle("Yamaha", "R15", 2022, "RS");
        moterCycle.displayBanner();
        moterCycle.display();
    }
}