using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_management
{
    public class ProductFood : Product
    {

        public DateOnly DateOfManufacture {  get ; set ; }
        public DateOnly ExpirationDate { get ; set ; }

        public override void Input()
        {
            throw new NotImplementedException();
        }
    }
}
