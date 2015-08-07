using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;

namespace RandomAccountGenerator
{
    class Program
    {
        static MySqlConnection connection;

        static void Main(string[] args)
        {
            string connectionString = string.Format("Server={0};Uid={1};Pwd={2};Database={3};Port={4};", "localhost", "root", "root", "test", 3306); ;
            connection = new MySqlConnection(connectionString);
            connection.Open();
            
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < 10000; i++)
            {
                var random = new Random();
                var count = new Random().Next(8, 16);
                var name = new string(Enumerable.Repeat(chars, count).Select(s => s[random.Next(s.Length)]).ToArray());
                CreateAccount(name);
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
        
        static void CreateAccount(string name)
        {
            MySqlCommand command = new MySqlCommand(string.Format("INSERT INTO account(username, sha_pass_hash, expansion) VALUES('{0}', SHA1(CONCAT(UPPER('{0}'), ':', UPPER('{0}'))), 2);", name), connection);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException mex)
            {
                Console.WriteLine("Error: " + mex.Message);
            }
        }
    }
}
