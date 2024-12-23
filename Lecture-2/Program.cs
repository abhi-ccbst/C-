﻿// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Hello, World!");


/*
if (condition)
{
}

Condition: 
a < b 
a <= b 
a > b 
a >= b 
a == b 
a != b
*/

int x = 10;
int y = 5;

if (x < y) {
    Console.WriteLine("if() x < y is true");
}

if (x > y) {
    Console.WriteLine("if() x > y is true");
}

if (20 > 10) {
    Console.WriteLine("20 > 10 is true ");
}

/*

//Condition is true 

if (condition) {
    execute
} else {
    //execute only when condition fail
}
*/
x = 5; 
y = 10;
if (x > y) {
    Console.WriteLine("if() esle {} x > y is true!");
} else {
    Console.WriteLine("if() esle {} x < y is true!");
}


/*
if (condition) {

} else if (condition) {

} else {
}
*/


x = 5;
y = 5;
if (x > y) {
    Console.WriteLine("if() else if() else() x > y is true!");
} else if (x == y) { //true
    Console.WriteLine("if() else if() else() x == y is true!");
} else if (x < 100) { //true
    Console.WriteLine("if() else if() else() x < 100 is true!");
} else if(x < y) {
    Console.WriteLine("if() else if() else() x < y is true!");
}

/*
Short Hand if... Else
(Ternary Operator)

variable = (condition) ? expressionTrue : expressionfalse
*/
int time = 20;

if (time < 18) {
    Console.WriteLine("Hello Abhi, Good Morniong");
} else {
    Console.WriteLine("Hello Abhi, Good evening");
}

string result = (time < 18) ? "Hello Abhi, Good Morniong" : "Hello Abhi, Good evening";
Console.WriteLine(result);


/*
Switch statements 
switch(expression) {
    case x:
        // code
        break;
    case y;
        // code
        break;
    default:
        // code
        break;
}
*/

int num = 70;
switch (num)
{
    case 1:
        Console.WriteLine("Its 1");
        break;
    case 2:
        Console.WriteLine("Its 2");
        break;
    case 3:
        Console.WriteLine("Its 3");
        break;
    case 4:
        Console.WriteLine("Its 4");
        break;
    case 5:
        Console.WriteLine("Its 5");
        break;
    case 6:
        Console.WriteLine("Its 6");
        break;
    case 7:
        Console.WriteLine("Its 7");
        break;
    case 8:
        Console.WriteLine("Its 8");
        break;
    case 9:
        Console.WriteLine("Its 9");
        break;
    case 10:
        Console.WriteLine("Its 10");
        break;
    default:
        Console.WriteLine("Its: " + num);
        break;
}


/*
While Loop
while (condition) {
}
*/

int i = 0;
while (i < 5) {
    Console.WriteLine("(while) The value of i: " + i);
    i++;
}

/*
do {
    // Code block
}while(condition)
*/
i = 0;
do {
    Console.WriteLine("do(While) The value of i: " + i);
    i++;
} while(i<5);


/*
for loop.. 
for (statement 1; statement 2; statement 3) {
}
*/

for (int j= 0; j <= 5; j++) {
    Console.WriteLine("The value of j: "+ j);
}

for (int j = 10; j >0; j-=2) {
    Console.WriteLine("The value of j: "+ j);
}
/*
foreach
*/

Console.WriteLine("\n\n\n");
/*
    Nested: 

*/
i= 0;
int z = 0;
while(i < 5) {
    z =0;
    Console.WriteLine("The value of i: " +i+ " and j: " +z);
    while(z < 5) {
        Console.WriteLine("\tj: " +z);
        z++;
    }
    i++;
}

Console.WriteLine("\n\n\n");
for (i = 0; i <5; i++ ){
    Console.WriteLine("The value of i: " +i+ " and j: " +z);
    for (z = 0; z < 5; z ++) {
        Console.WriteLine("\tj: " +z);
    }
}


for (i = 0; i < 5; i++) {
    for(z = 0; z <=i; z++ ) {
        Console.Write(" *");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");
for (i = 5; i > 0; i--) {
    for(z = 0; z <=i; z++) {
        Console.Write(" *");
    }
    Console.WriteLine();
}