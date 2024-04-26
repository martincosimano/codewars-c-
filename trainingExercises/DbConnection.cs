namespace InheritancePractice
{
        public abstract class DbConnection
        {
            private string _connectionString;
            public TimeSpan Timeout { get; set; }

            public abstract void OpenConnection();
            public abstract void CloseConnection();

        public DbConnection(string connectionString)
        {
            if (connectionString == null) throw new ArgumentNullException();
            _connectionString = connectionString;
        }
    }
}