using System.Collections;

namespace InheritancePractice
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("key");
            sql.OpenConnection();
            sql.CloseConnection();

            var oracle = new OracleConnection("key");
            oracle.OpenConnection();
            oracle.CloseConnection();
        }
    }
}