namespace InheritancePractice
{
    public class OracleConnection : DbConnection
    {
        public override void OpenConnection()
        {
            Console.WriteLine("Connection with Oracle is open");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Connection with Oracle is closed");
        }

        public OracleConnection(string connectionString)
            : base(connectionString)
        {
            
        }
    }
}
