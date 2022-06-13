using System.Data.SqlClient;
using Dapper;


namespace RetrieveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = @"Data Source=LENOVODEV\LENOVOSERVER;Initial Catalog=dbdapper;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using var con = new SqlConnection(cs);
            con.Open();

            var cars = con.Query<Car>("SELECT * FROM cars").ToList();

            cars.ForEach(car => Console.WriteLine(car));
        }
    }
}

