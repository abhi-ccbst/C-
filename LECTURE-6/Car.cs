class Car : Vehicle
{
    public string CarName {set; get;}
    public Car (string make, string model, int year, string carName) : base(make, model, year) {
        CarName = carName;
    }
    public override void display()
    {
        Console.WriteLine($"Car:\t{CarName}");
    }
}