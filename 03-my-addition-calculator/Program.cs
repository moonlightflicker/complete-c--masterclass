﻿// See https://aka.ms/new-console-template for more information

//Console.Write("Enter a whole number: ");
Console.Write("Enter a number: ");

// We can't use an int because Console.ReadLine() returns a string
//string userInput = Console.ReadLine();

// Parsing
double userInput1 = 0.0;
double userInput2 = 0.0;
//int userInput1 = int.Parse(Console.ReadLine());

userInput1 = double.Parse(Console.ReadLine());

//Console.Write("Enter a whole number: ");
Console.Write("Enter a number: ");

userInput2 = double.Parse(Console.ReadLine());

//int userInput2 = int.Parse(Console.ReadLine());

double sum = userInput1 + userInput2;

//Console.WriteLine($"{userInput1} + {userInput2} = {userInput1 + userInput2}");
Console.WriteLine($"{userInput1} + {userInput2} = {sum}");
