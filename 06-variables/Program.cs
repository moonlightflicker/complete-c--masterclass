namespace _06_variables;

class Program
{
    static void Main(string[] args)
    {
        // Implicitly typed variable
        var myFavouriteGenre = "rock";
        var myFavouriteNumber = 7;
        
        // Explicitly types variable
        string myFavouriteMovie = "Die Hard";
        int yourFavouriteNumber = 3;
        
        // This does not work
        //myFavouriteGenre = yourFavouriteNumber;



        var sum = myFavouriteNumber + yourFavouriteNumber;
        Console.WriteLine(sum);



        char myFavouriteChar = 'Z';
        Console.WriteLine(myFavouriteChar);
        myFavouriteChar = '\u2665';
        Console.WriteLine(myFavouriteChar);
    }
}