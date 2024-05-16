// See https://aka.ms/new-console-template for more information

Console.Write("Enter a whole number: ");

// We can't use an int because Console.ReadLine() returns a string
//string userInput = Console.ReadLine();

// Parsing
int userInput = int.Parse(Console.ReadLine());

Console.WriteLine("Value entered: " + userInput);
