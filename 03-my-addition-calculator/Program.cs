// See https://aka.ms/new-console-template for more information

//Console.Write("Enter a whole number: ");

using System.Globalization;

Console.Write("Enter a number: ");

// We can't use an int because Console.ReadLine() returns a string
//string userInput = Console.ReadLine();

// Parsing
double userInput1 = 0.0;
double userInput2 = 0.0;
//int userInput1 = int.Parse(Console.ReadLine());

userInput1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.Write("Enter a whole number: ");
Console.Write("Enter a number: ");

userInput2 = double.Parse(Console.ReadLine(),  CultureInfo.InvariantCulture);

//int userInput2 = int.Parse(Console.ReadLine());

double sum = Math.Round(userInput1 + userInput2, 3);

//Console.WriteLine($"{userInput1} + {userInput2} = {userInput1 + userInput2}");
Console.WriteLine($"{userInput1.ToString(CultureInfo.InvariantCulture)} + " +
                  $"{userInput2.ToString(CultureInfo.InvariantCulture)} = " +
                  $"{sum.ToString(CultureInfo.InvariantCulture)}");
