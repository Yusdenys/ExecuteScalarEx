using Dapper;
using System.Data.SqlClient;


namespace UpdateRow
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = @"Data Source=LENOVODEV\LENOVOSERVER;Initial Catalog=dbdapper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using var con = new SqlConnection(cs);
            con.Open();

            int nOfRows = con.Execute("UPDATE dbo.[cars] SET [price] = 52000 WHERE [id] = 1");
            Console.WriteLine("'UPDATE' affected rows: {0}", nOfRows);

        }
    }
}
