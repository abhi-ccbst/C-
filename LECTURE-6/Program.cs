class Program {
    static void Main(string[] args) {
        Car car = new Car();
        car.print();
        car.name();

        Ford ford = new Ford();
        ford.print();
        ford.name();

        Honda honda = new Honda();
        honda.print();
        honda.name();

        Car fordCar = new Ford();
        fordCar.print();
        fordCar.name();
    }
}


// Polymorphism
//virtual keyword to the method inside te base class and override keyword for each derived class then it work as we asumed



