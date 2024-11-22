// See https://aka.ms/new-console-template for more information
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