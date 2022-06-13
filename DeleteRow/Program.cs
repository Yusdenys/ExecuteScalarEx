using System.Data.SqlClient;
using Dapper;


namespace ExecuteScalarEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = @"Data Source=LENOVODEV\LENOVOSERVER;Initial Catalog=dbdapper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using var con = new SqlConnection(cs);
            con.Open();

            var delRows = con.Execute(@"DELETE FROM [cars] WHERE Id = @Id", new { Id = 1 });

            if (delRows > 0)
            {
                Console.WriteLine("car deleted");
            }
        }
    }
}