using System.Threading.Channels;

namespace _08_exercise_2;

class Program
{
    static void Main(string[] args)
    {
        CalculateAverage();
    }
    
    public static void CalculateAverage()
    {
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;
        int average = (num1 + num2 + num3) / 3;
        Console.WriteLine("The average is: " + average);
    }
}