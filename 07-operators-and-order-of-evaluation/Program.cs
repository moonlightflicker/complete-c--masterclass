namespace _07_operators_and_order_of_evaluation;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 6;
        int num2 = 3;

        // 53
        Console.WriteLine("num1 + num2 = " + num1 + num2);
        
        // This is the right way
        Console.WriteLine("num1 + num2 = " + (num1 + num2));
        
        // Not possible
        //Console.WriteLine("num1 - num2 = " + num1 - num2);
        // With bracket it is
        Console.WriteLine("num1 - num2 = " + (num1 - num2));
        
        // Multiplication has priority
        Console.WriteLine("num1 * num2 = " + num1 * num2);
        
        // Division has priority
        Console.WriteLine("num1 / num2 = " + num1 / num2);
    }
}