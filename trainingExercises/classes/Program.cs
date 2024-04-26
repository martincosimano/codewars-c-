namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var myStopwatch = new Stopwatch();
            myStopwatch.Start();
            System.Threading.Thread.Sleep(2000);
            myStopwatch.Stop();

            Console.WriteLine(myStopwatch.Duration);
        }
    }
}