using LibMenu;
using System.Security.Cryptography.X509Certificates;
using MySqlConnector;
using System.Text;

namespace Supermarket_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new();

            int SelectLanguage = menu.ShowSelectMenuLanguage();
            Console.Clear();
            string[] Category = Array.Empty<string>();

            while (true)
            {
                int SelectMenu = menu.ShowSelectMenuApp(SelectLanguage);
                Console.Clear();

                switch (SelectMenu)
                {
                    case 1:
                        Console.WriteLine("Ban chon 1");
                        Console.Write("Nhap ten : ");
                        string s = Console.ReadLine() ?? string.Empty;
                        Console.WriteLine($"Ten cua ban la : {s}");
                        BackMenu();
                        break;
                    case 2:
                        Console.WriteLine("Ban chon 2");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        menu.ShowMenu(GetData());
                        //BackMenu();
                        break;
                    case 4:
                        Console.WriteLine("Input new product eletronic : ");
                        Product p1 = new ProductElectronic("quat","C10",200,85);
                        p1.Show();
                        BackMenu();
                        break;
                    case 5:
                        Console.WriteLine("Input new product Appliances : ");
                        Product p2 = new ProductAppliances();
                        p2.Input();
                        p2.Show();
                        BackMenu();
                        break;

                    case 8:
                        return;
                    default:
                        break;

                }
            }

           

        }

        public static void BackMenu()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Press any key to back menu");
            Console.ReadLine();
            Console.Clear();

        }

        public static  List<string> GetData()
        {
            List<string> CategoryName = new List<string>();
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "",
                Database = "supermarket",
            };

            using var connection = new MySqlConnection(builder.ConnectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"SELECT name FROM category";

            using var reader = command.ExecuteReader();

            while(reader.Read())
            {
                //var id = reader.GetInt32("id");
                //var code = reader.GetString("code");
                var name = reader.GetString("name");
                CategoryName.Add(name);
                Console.WriteLine(name);
                //Console.WriteLine($"Id: {id} -- Code: {code} -- Name: {name}");

            }
            return CategoryName;


        }


    }
}