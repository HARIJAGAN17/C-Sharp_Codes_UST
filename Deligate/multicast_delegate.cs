using System;

class Deligate
{
    public delegate int DeligatePointer(int number);
    public static void Main(String[] args)
    {
    DeligatePointer d = new DeligatePointer(TestFunction);
    d += TestMethod2;// multicast deligate

    int result = d(22);
    Console.WriteLine($"I'm called through the deligate:{result}");//result overriden
    }

    public static int TestFunction(int number)
    {
        return number;//22
    }

    public static int TestMethod2(int number){
        return number + 2;//22+2
    }
}