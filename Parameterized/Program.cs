using System.Data.SqlClient;
using Dapper;


namespace Parameterized
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = @"Data Source=LENOVODEV\LENOVOSERVER;Initial Catalog=dbdapper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using var con = new SqlConnection(cs);
            con.Open();

            var car = con.QueryFirst<Car>("SELECT * FROM cars WHERE id=@id", new { id = 3 });

            Console.WriteLine(car);
        }
    }
}