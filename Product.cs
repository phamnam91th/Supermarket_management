using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_management
{
    public abstract class Product : IProduct
    {
        public int Id { get; set; }
        public string? Name { get ; set ; }
        public string? Code { get ; set ; }
        public int? Price { get ; set ; }

        public Product()
        {

        }

        public Product(string? name, string? code, int? price)
        {
            Name = name;
            Code = code;
            Price = price;
        }

        public virtual  void Input()
        {
            Console.Write("Enter name : ");
            this.Name = Console.ReadLine();
            Console.Write("Enter code : ");
            this.Code = Console.ReadLine();
            Console.Write("Enter price : ");
            this.Price = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name} -- Code: {Code} -- Price: {Price}");
        }
    }
}
