namespace _12_exercise_4;

class Program
{
    static void Main(string[] args)
    {
        CheckLogin();
    }
    
    public static void CheckLogin()
    {
        string input = Console.ReadLine();
        bool isLoggedIn = input != null && input.Length > 0;

        if (!isLoggedIn)
        {
            Console.WriteLine("Welcome back!");
        }
        else
        {
            Console.WriteLine("Please log in.");
        }
    }
}