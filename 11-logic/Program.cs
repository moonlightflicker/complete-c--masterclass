namespace _11_logic;

class Program
{
    static void Main(string[] args)
    {
        bool isRainy = false;
        bool hasUmbrella = true;
        
        // OPERATORS
        // AND &&
        // OR ||
        // NOT !

        if (isRainy && hasUmbrella)
        {
            Console.WriteLine("It's rainy, but I have and umbrella");
        }
        
        
        if (!isRainy || hasUmbrella)
        {
            Console.WriteLine("I'm not getting wet");
        }

        Console.WriteLine("The program ran");
    }
}