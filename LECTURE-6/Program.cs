class Program {
    static void Main(string[] args) {
        // Car car = new Car();
        // car.print();
        // car.name();

        Ford ford = new Ford();
        ford.print();
        ford.name();
        ford.carPrice();

        Honda honda = new Honda();
        honda.print();
        honda.name();
        honda.carPrice();

        Car fordCar = new Ford();
        fordCar.print();
        fordCar.name();
        fordCar.carPrice();
    }
}


// Polymorphism
//virtual keyword to the method inside te base class and override keyword for each derived class then it work as we asumed



