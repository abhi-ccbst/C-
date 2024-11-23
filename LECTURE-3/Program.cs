// See https://aka.ms/new-console-template for more information
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Hello, World!");


/*
 break;*/


int i = 0;

while(i < 10) {
    Console.WriteLine("(While)The value of i: "+i);
    if (i==4) {
        break;
    }
    i++;
}

Console.WriteLine("\n\n");

for (i = 0; i < 10; i++) {
    Console.WriteLine("(for)The value of i: "+i);
    if (i==4) {
        break;
    }
}

i = 0;
while (i < 10) {
    Console.WriteLine("(While)The value of i: "+i);
    i++;

    if (i == 4) {
        continue;
    }
    Console.WriteLine("**");
}


/*
Arrays: 
string[] food = {""}'
Array count start from 0.
*/
// Option: 1
string[] colors = {"red", "blue", "green", "white"};
int[] counts = {1, 2, 3, 4};
colors[0] = "black";
Console.WriteLine(colors[0]);
Console.WriteLine(counts[0]);

Console.WriteLine(colors.Length);

// Option 2
string[] carCompany = new string[4];
carCompany[0] = "mazda";
carCompany[1] = "ford";
carCompany[2] = "honda";
carCompany[3] = "toyota";

Console.WriteLine(carCompany.Length);

//Option 3
string[] cars = new string[] {"mustang", "civic", "corolla", "bmw"};

for (i = 0; i < cars.Length; i++) {
    Console.WriteLine($"The elemnt at index {i} is {cars[i]}");
}

/*
foreach(type variblename in arrayName) {}
*/
foreach(string car in cars) {
    Console.WriteLine($"value of car is {car}");
}

/*
Array.Sort(cars)
alp

acending to decending
*/

Array.Sort(cars);

foreach(string car in cars) {
    Console.WriteLine($"value of car is {car}");
}
Array.Sort(counts);
foreach(int car in counts) {
    Console.WriteLine($"value of count is {car}");
}
Console.WriteLine(counts.Max());
Console.WriteLine(counts.Min());
Console.WriteLine(counts.Sum());

Console.Write("Enter your name: ");
string name = Console.ReadLine();

// Integer input
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());

// Boolean input
Console.Write("Are you a student? (true/false): ");
bool isStudent = bool.Parse(Console.ReadLine());

// Array input
Console.Write("Enter your favorite hobbies (comma-separated): ");
string[] hobbies = Console.ReadLine().Split(',');

// Float input
Console.Write("Enter your GPA: ");
float gpa = float.Parse(Console.ReadLine());

// Output all inputs
Console.WriteLine("\n--- User Information ---");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Is Student: {isStudent}");
Console.WriteLine($"Hobbies: {string.Join(", ", hobbies)}");
Console.WriteLine($"GPA: {gpa}");


Console.Write("Enter your name: ");
String newName = Console.ReadLine();

Console.Write("Enter your age: ");
int newAge = Convert.ToInt32(Console.ReadLine());

Console.Write("Are you a student: ");
bool newIsStudent = bool.Parse(Console.ReadLine());

Console.Write("Enter how many hoobies you have(int): ");
int lenght = int.Parse(Console.ReadLine()); //4

string[] newHobbies = new string[lenght];
for(i = 0; i < lenght; i++) {
    Console.Write($"Enter you {i + 1} hobby: ");
    newHobbies[i] = Console.ReadLine();
}

Console.Write("Enter you GPA: ");
float gpaNew = float.Parse(Console.ReadLine());

Console.WriteLine("\n--- User Information ---");
Console.WriteLine($"Name: {newName}");
Console.WriteLine($"Age: {newAge}");
Console.WriteLine($"Is Student: {newIsStudent}");
Console.WriteLine($"Hobbies: {string.Join(". ", newHobbies)}");
Console.WriteLine($"GPA: {gpaNew}");