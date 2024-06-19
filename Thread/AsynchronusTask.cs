namespace AsynAwait
{
    internal class Program
    {
        async static Task Main(string[] args)
        {

            var downloadTask = GettingData();
            Console.WriteLine("Web Page Loading process");
            Console.WriteLine(await downloadTask);
        }


        async static Task<String> GettingData()
        {
            Console.WriteLine("Download started in background");

            await Task.Delay(3000);

            return "Download Completed";
        }
    }


}
