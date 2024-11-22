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