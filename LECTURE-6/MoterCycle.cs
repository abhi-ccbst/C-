class MoterCycle : Vehicle
{
    public string MoterCycleName {set; get;}

    /*
    * Constructor
    */
    public MoterCycle (string make, string model, int year, string moterCycleName) : base(make, model, year) {
        MoterCycleName = moterCycleName;
    }

    /*
    * This method print the Vehcile information.
    */
    public override void display()
    {
        Console.WriteLine($"MoterCycle:\t{MoterCycleName}");
    }
}