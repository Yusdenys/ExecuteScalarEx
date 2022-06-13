using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace InsertRow
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = @"Data Source=LENOVODEV\LENOVOSERVER;Initial Catalog=dbdapper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using var con = new SqlConnection(cs);
            con.Open();

            var query = "INSERT INTO cars(name, price) VALUES(@name, @price)";

            var dp = new DynamicParameters();
            dp.Add("@name", "BMW", DbType.AnsiString, ParameterDirection.Input, 255);
            dp.Add("@price", 36600);

            int res = con.Execute(query, dp);

            if (res > 0)
            {
                Console.WriteLine("row inserted");
            }
        }
    }
}