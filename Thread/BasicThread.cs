namespace TestThread
{

    class SecondClass
    {


        public static void TestMethod1()
        {
            Console.WriteLine("Thread without parameter");
        }

        public static void TestMethod2(object s) {

            s = (string)s;

            Console.WriteLine($"Thread with {s}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(SecondClass.TestMethod1);
            t.Start();

            Thread tt = new Thread(SecondClass.TestMethod2);
            tt.Start("Parameter");
        }
    }
}
