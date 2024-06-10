using System;

class Deligate
{
    public delegate int DeligatePointer(int number);
    public static void Main(String[] args)
    {
    DeligatePointer d = new DeligatePointer(TestFunction);
    int result = d(22);
    Console.WriteLine($"I'm called through the deligate:{result}");
    }

    public static int TestFunction(int number)
    {
        return number;
    }
}
