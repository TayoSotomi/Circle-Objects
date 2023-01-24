
using Circle_Objects;
using System.Security.Cryptography.X509Certificates;

bool ToContinue = true;
double radius;

Console.WriteLine("Welcome to the Circle Tester");
Console.WriteLine();

while (ToContinue)
{

    Console.Write("Please enter radius: ");

    while( double.TryParse(Console.ReadLine(),out radius) ==false)
    {
        Console.WriteLine("invalid input. Please enter radius");
    }
    if (true)
    {
        Circle myCircle = new Circle(radius);
        Console.WriteLine(myCircle.CalculateFormattedArea());
        Console.WriteLine(myCircle.CalculateFormatedCircumference());
    }

    Console.WriteLine("Would you like to continue? y/n ");
    string input = Console.ReadLine();


    if(input == "y")
    {
        ToContinue = true;
    }
    else if(input == "n")
    {
        ToContinue = false;
        Console.WriteLine($"Goodbye. You created {Circle.getCount()} Circle object(s).");
    }
    else
    {
        Console.WriteLine("Please enter valid value");
    }
}







