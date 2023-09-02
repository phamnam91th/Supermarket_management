using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_management
{
    public class ProductElectronic : Product
    {
        public int Power { get; set; }

        public ProductElectronic() { }
        public ProductElectronic(string name, string code, int price,int power) :base(name,code,price) { 
            this.Power = power;
        }
        
        public override void Input()
        {
            Console.Write("Enter name : ");
            this.Name = Console.ReadLine();
            Console.Write("Enter code : ");
            this.Code = Console.ReadLine();
            Console.Write("Enter price : ");
            this.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter power : ");
            this.Power = Convert.ToInt32(Console.ReadLine());
        }

        public override  void Show()
        {
            Console.WriteLine($"Name: {Name} -- Code: {Code} -- Price: {Price} -- Power: {Power}");
        }
    }
}
