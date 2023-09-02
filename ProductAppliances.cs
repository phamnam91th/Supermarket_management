using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_management
{
    public class ProductAppliances : Product
    {
        public string? Action {  get; set; }

        public override  void Input()
        {
            Console.Write("Enter name : ");
            this.Name = Console.ReadLine();
            Console.Write("Enter code : ");
            this.Code = Console.ReadLine();
            Console.Write("Enter price : ");
            this.Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter action : ");
            this.Action = Console.ReadLine();
        }

        public override void Show()
        {
            Console.WriteLine($"Name: {Name} -- Code: {Code} -- Price: {Price} -- Action: {Action}");
        }
    }
}
