namespace InheritancePractice
{
    public class SqlConnection : DbConnection
    {

        public override void OpenConnection()
        {
            Console.WriteLine("Connection with SQL is open");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Connection with SQL is closed");
        }

        public SqlConnection(string connectionString)
            : base(connectionString)
        {

        }
        
    }
}