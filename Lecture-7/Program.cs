// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



class Program {
    enum Drink {
        CHAI,  // 0
        COFFEE, // 1
        TEA, //2
        SODA, //3
        DAIRY_PRODUCTS //4
    }

    static void Main(string[] args) {
        int drinkNum = (int) Drink.COFFEE;
        Console.WriteLine(drinkNum);

        Drink drink = Drink.SODA;

        switch (drink) {
            case Drink.CHAI:
                Console.WriteLine("It is a Chai");
                break;
            case Drink.DAIRY_PRODUCTS: 
                Console.WriteLine("It is a Dairy product");
                break;

            case Drink.SODA: 
                Console.WriteLine("Its is a SODA");
                break;
            default: 
                Console.WriteLine("Not able to identify");
                break;            
        }
    }
}