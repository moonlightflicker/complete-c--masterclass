namespace _05_conversions;

class Program
{
    static void Main(string[] args)
    {
        // Implicit conversion
        int myInt = 1231321321;
        double myDouble = myInt;

        long myLong = myInt;

        // Can't do this because myInt can't store as much data as myLong
        //myInt = myLong;

        myLong = 1231231263546548848;
        //myInt = myLong;

        float myFloat = 123.123f;
        myDouble = myFloat;
        
        
        // Explicit conversion
        // The number is different because it can't store all data, even though it "works"
        int myInt2 = (int) myLong;
        Console.WriteLine(myInt2);

        // In this case it works fine because it can store all data
        myLong = 123;
        myInt2 = (int) myLong;
        Console.WriteLine(myInt2);

        // It can't store the whole number again
        myDouble = 13.2123123123;
        myFloat = (float)myDouble;
        Console.WriteLine(myFloat);

        // It can't store the whole number again
        int myInt3;
        double myDouble3 = 13.5;
        myInt3 = (int)myDouble3;
        Console.WriteLine(myInt3);
    }
}