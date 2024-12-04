
using System.ComponentModel;

namespace ComprehensiveCSharpProject {
    interface IMathOperations {
        double Add();
        double Subtract();
        double Multiply();
        double Divide();
    }

    abstract class Calculator : IMathOperations
    {
        public double A {set; get;}
        public double B {set; get;}

        public Calculator(double a, double b) {
            A = a;
            B = b;
            printValue();
        }

        void printValue() {
            Console.WriteLine($"\n\nThe user values are: {A} and {B}");
        }

        public abstract double Add();

        public abstract double Divide();

        public abstract double Multiply();

        public abstract double Subtract();

        public abstract void Print();

        public double Power() {
            return Math.Pow(A, B);
        }

        public double Sqrt() {
            return Math.Sqrt(A);
        }
    }

    class SimpleCalculator : Calculator {

        public SimpleCalculator(double a, double b): base(a, b) {

        }
        public override double Add()
        {
            return A + B;
        }

        public override double Subtract()
        {
            return A - B;
        }

        public override double Multiply()
        {
            return A * B;
        }

        public override double Divide()
        {
            if (B == 0) {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return A/B;
        }

        public override void Print() {
            Console.WriteLine($"\t\nAddition: {Add()}, \t\nSubtraction: {Subtract()}, \t\nMultiplication: {Multiply()}, \t\nDivision: {Divide()}, \t\nPower: {Power()}, \t\nSqrt: {Sqrt()}");
        }
    }

    class Program {
        static void Main(String[] args) {
            // Console.Write("Enter an int number: ");
            // String input = Console.ReadLine();
            // int userInt = int.Parse(input);
            // Console.WriteLine($"The entered value is: {userInt}");
            
            Console.Write("Enter first num: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter second num: ");
            double b = double.Parse(Console.ReadLine());
            
            Calculator calc = new SimpleCalculator(a, b);
            calc.Print();            

            Random random = new Random();
            double x = random.Next(1, 100); //1 - 99
            double y = random.Next(50); // 0 - 49
            Calculator cal = new SimpleCalculator(x, y);
            cal.Print();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}