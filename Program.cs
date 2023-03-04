using System;


Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------");

// Ask the user to type the coordinates.
//Coordinates for dot A
Console.WriteLine("Enter coordinate x of dot A");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot A");
double y1 = Convert.ToInt32(Console.ReadLine());
//Coordinates for dot B
Console.WriteLine("Enter coordinate x of dot B");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot B");
double y2 = Convert.ToInt32(Console.ReadLine());
//Coordinates for dot C
Console.WriteLine("Enter coordinate x of dot B");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter coordinate y of dot B");
double y3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("------------------------");

//Finding sides length
double a = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
double c = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

//Validation

if (a == 0 && b == 0 && c == 0)
{
    Console.WriteLine("Can't calculate with set parameters.");
    return;
};

Console.WriteLine("The length of the side AB " + a);
Console.WriteLine("The length of the side BC " + b);
Console.WriteLine("The length of the side CA " + c);
// Check is this triangle is equilateral? 
if (a == b && b == c && c == a)
{
    Console.WriteLine("The triangle IS 'Equilateral'");
}
else
{
    Console.WriteLine("The triangle IS NOT 'Equilateral'");
}
//Check is this triangle is isosceles?
if (a == b || b == c || c == a)
{
    Console.WriteLine("The triangle IS 'Isosceles'");
}
else
{
    Console.WriteLine("The triangle is NOT 'Isosceles'");
}
//Check is this triangle is right?

double aSqrt = Math.Round(Math.Pow(a, 2));
double bSqrt = Math.Round(Math.Pow(b, 2));
double cSqrt = Math.Round(Math.Pow(c, 2));

if (aSqrt == bSqrt + cSqrt || bSqrt == aSqrt + cSqrt || cSqrt == aSqrt + bSqrt)
{
    Console.WriteLine("The triangle IS 'Right'");
}
else
{
    Console.WriteLine("The triangle IS NOT 'Right'");
}

Console.WriteLine("------------------------");

//Perimeter
double perimeter = a + b + c;
Console.WriteLine("Perimeter: " + perimeter);

Console.WriteLine("------------------------");
Console.WriteLine("Parity numbers in range from 0 to triangle perimeter:");
for (var i = 0; i < perimeter; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
