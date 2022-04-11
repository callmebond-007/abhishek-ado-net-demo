using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Open a connection with the database.

            string connectionString = @"data source=(localdb)\MSSQLLocalDB;database=StudentDB;integrated security=SSPI";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Connection is established!!!");

            }

            Console.ReadLine();
        }
    }
}
