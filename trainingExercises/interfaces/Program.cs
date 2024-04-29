namespace Practice
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.LoadActivity(new Activity1());
            workflow.LoadActivity(new Activity2());
            workflow.Run();
        }
    }
}