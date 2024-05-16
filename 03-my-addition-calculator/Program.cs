// See https://aka.ms/new-console-template for more information

Console.Write("Enter a whole number: ");

// We can't use an int because Console.ReadLine() returns a string
//string userInput = Console.ReadLine();

// Parsing
int userInput1 = int.Parse(Console.ReadLine());

Console.Write("Enter a whole number: ");

int userInput2 = int.Parse(Console.ReadLine());

Console.WriteLine($"{userInput1} + {userInput2} = {userInput1 + userInput2}");
