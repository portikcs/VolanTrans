using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VolanTrans.TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            MySqlConnection connection = new MySqlConnection(
                "Server=mysql.stackcp.com;Port=49952;SslMode=none;UID=cypres;password=mw81xv6plf;database=VolanTrans-3333e51c");

            connection.Open();

            string query = "SELECT * FROM Users";
            var cmd = new MySqlCommand(query, connection);
            var reader = cmd.ExecuteReader();
            Console.WriteLine("Users");
            Console.WriteLine("------------------------------------------------");
            while (reader.Read())
            {
                Console.WriteLine(
                    $"User id : {reader.GetInt64(0)} User name : {reader.GetString(1)}, Password : {reader.GetString(2)}");
                Console.WriteLine("------------------------------------------------");
            }
            connection.Close();

            Console.ReadLine();

        }
    }
}
