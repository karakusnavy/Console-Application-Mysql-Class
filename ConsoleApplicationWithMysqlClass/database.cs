using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWithMysqlClass
{
    class database
    {
        public MySqlConnection con = new MySqlConnection("Server=localhost;Database=testdatabase;Uid=root;Pwd=;");        
        public void insert_personel()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Insert Personel System");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Please enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter the surname: ");
            string surname = Console.ReadLine();
            Console.Write("Please enter the age: ");
            int age = int.Parse(Console.ReadLine());
            MySqlCommand cmd = new MySqlCommand("insert into example_table(name,surname,age) values('"+name+"','"+surname+"',"+age+")",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succesfull!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void delete_personel()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Delete Personel System");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
            MySqlCommand cmd = new MySqlCommand("select * from example_table",con);
            con.Open();
            MySqlDataReader reading = cmd.ExecuteReader();
            while (reading.Read())
            {
                Console.WriteLine(reading["id"].ToString() + " - " + reading["name"].ToString() + " - " + reading["surname"].ToString()+" - "+reading["age"].ToString());
            }
            con.Close();
            Console.WriteLine("");
            Console.Write("Please enter the deleting perseonel number: ");
            int id = int.Parse(Console.ReadLine());
            MySqlCommand cmd2 = new MySqlCommand("delete from example_table where id = "+id+"",con);
            con.Open();
            cmd2.ExecuteNonQuery();
            con.Close();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Succesfull!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void list_personel()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to List Personel System");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
            MySqlCommand cmd = new MySqlCommand("select * from example_table", con);
            con.Open();
            MySqlDataReader reading = cmd.ExecuteReader();
            Console.WriteLine("----------------------------------------------------------------------------------------");
            while (reading.Read())
            {
                Console.WriteLine(reading["id"].ToString() + " - " + reading["name"].ToString() + " - " + reading["surname"].ToString() + " - " + reading["age"].ToString());
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
            con.Close();
        }
    }
}
