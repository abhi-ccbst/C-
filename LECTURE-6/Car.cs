abstract class Car {
    public void print() {
        Console.WriteLine("I am in Car class");
    }

    public virtual void name() {
        Console.WriteLine("I am in Car class.");
    }

    public abstract void carPrice();
}