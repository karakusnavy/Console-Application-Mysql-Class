using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWithMysqlClass
{
    class Program
    {
        static void Main(string[] args)
        {
        
            database db = new database();
            Console.WriteLine("Welcome to personel list.");
            again:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1-) Insert new personel.");
            Console.WriteLine("2-) Delete a personel.");
            Console.WriteLine("3-) Personel list");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Please select a number: ");
            string number = Console.ReadLine();
            if (number == "1")
            {
                db.insert_personel();
                goto again;
            }
            else if (number == "2")
            {
                db.delete_personel();
                goto again;
            }
            else if (number == "3")
            {
                db.list_personel();
                goto again;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong number!");
                Console.ForegroundColor = ConsoleColor.Gray;
                goto again;
            }
            Console.ReadLine();
        }
    }
}
