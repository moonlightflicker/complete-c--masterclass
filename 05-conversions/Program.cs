namespace _05_conversions;

class Program
{
    static void Main(string[] args)
    {
        int myInt = 1231321321;
        double myDouble = myInt;

        long myLong = myInt;

        // Can't do this because myInt can't store as much data as myLong
        //myInt = myLong;

        myLong = 1231231263546548848;
        //myInt = myLong;

        float myFloat = 123.123f;
        myDouble = myFloat;
    }
}