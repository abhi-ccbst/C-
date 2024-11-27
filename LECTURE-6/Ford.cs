class Ford : Car {
    public void print() {
        Console.WriteLine("I am in Ford class");
    }

    public override void name() {
        Console.WriteLine("I am in Ford class");
    }

    public override void carPrice()
    {
        Console.WriteLine("The price of Ford is $40K");
    }
}