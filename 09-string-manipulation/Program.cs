﻿namespace _09_string_manipulation;

class Program
{
    static void Main(string[] args)
    {
        int num = 10;
        double price = 19.95;
        string name = "Frieren";

        // Interpolation
        Console.WriteLine($"The number is {num}");
        // Concatenation
        Console.WriteLine("The number is " + num);
        
        // String formating
        Console.WriteLine("The number is {0}, and the price is {1} and my friend's name is {2}", num, price, name);



        string s1 = "this is a string with a / and a : ";
        Console.WriteLine(s1);
        
        string s2 = "this is a \"string\" with a / and a :. This is a back slash \\";
        Console.WriteLine(s2);
    }
}