// class Ford : Car {
//     public void print() {
//         Console.WriteLine("I am in Ford class");
//     }

//     public override void name() {
//         Console.WriteLine("I am in Ford class");
//     }

//     public override void carPrice()
//     {
//         Console.WriteLine("The price of Ford is $40K");
//     }
// }

class Ford : Car , Vehicle
{
    public void name()
    {
        Console.WriteLine("I am in Ford class");
    }

    public void carPrice()
    {
        Console.WriteLine("The price of Ford is $40K");
    }

    public int test(int abc ) {
        return 0;
    }
}