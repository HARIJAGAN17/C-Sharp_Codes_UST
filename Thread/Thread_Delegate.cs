namespace Thread_Delegate
{

    class Number
    {


        public int receiver { get; set; }
        Action<int> summDelegate;

        public Number(int receiver,Action<int> callSum)
        {
            this.receiver = receiver;
            summDelegate = callSum;
        }

        public void  sum()
        {
            int sum = receiver;
            sum += 2;
            
            summDelegate(sum);
          
        }
  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number(22,prinSum); ;
            Thread threadOne = new Thread(number.sum);
            threadOne.Start();
        }

        public static void prinSum(int sum)
        {
            Console.WriteLine( sum);
        }
    }
}
