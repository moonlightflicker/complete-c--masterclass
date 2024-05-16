namespace _02_hello_world;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("This time, I'm not using top level statements\n");

        // Declaring a string variable
        string myFriendsName;
        
        // Assigning a value to that string variable
        myFriendsName = "Frieren";
        
        // Using the variable
        Console.WriteLine(myFriendsName);
        
        // Changing the variable's value
        myFriendsName = "Stark";
        
        // Writing the variable's value to the console
        Console.WriteLine(myFriendsName);
        
        // Declaring a new variable and assigning a value
        string myThirdFriendsName = "Fern";
        
        // Writing the new  variable's value to the console
        Console.WriteLine(myThirdFriendsName);

        //Console.ReadKey();
    }
}