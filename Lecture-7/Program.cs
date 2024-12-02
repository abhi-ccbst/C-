/*
AppendText()     Append text at the end of an existing file 
Copy()           Copies a file
Create()         Creates or overwrites a file
Delete()         Deletes a file
Exists()         tests whether the file exits 
ReadAllText()    Reads the contents of a file
Replace()        Replaces the contents of a file with the contents of another file. 
WriteAllText()   Creates a new file and writes the contents to it. If the file already exist, it will be overwritten. 
*/

class Program {
    enum Drink {
        CHAI,  // 0
        COFFEE, // 1
        TEA, // 2
        SODA, // 3
        DAIRY_PRODUCTS // 4
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
                Console.WriteLine("It's a SODA");
                break;
            default:
                Console.WriteLine("Not able to identify");
                break;            
        }

        // Create file and write text to it
        File.Create("bin/test.txt").Close(); // Close the file after creating
        string writetext = "Hello From C#";
        File.WriteAllText("bin/test.txt", writetext);

        // Append more text
        string appendtext = " I am appending something";
        File.AppendAllText("bin/test.txt", appendtext);

        // Read text and display
        string readtext = File.ReadAllText("bin/test.txt");
        Console.WriteLine(readtext);

        // Create and replace file (ensure destination file exists)
        File.Create("bin/test1.txt").Close();
        File.Create("bin/test2.txt").Close();
        File.Replace("bin/test.txt", "bin/test1.txt", "bin/test2.txt");

        // Copy the file
        File.Copy("bin/test1.txt", "tes45.txt");

        // Check if file exists before deletion
        bool isExists = File.Exists("bin/test.txt");
        Console.WriteLine(isExists); // Should print True

        // Delete the original file
        File.Delete("bin/test.txt");

        // Final check if the file was deleted
        isExists = File.Exists("bin/test.txt");
        Console.WriteLine(isExists); // Should print False
    }
}
