using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal interface IDrink
    {
        int price { get; }
        string name { get; }
        void Drink();
    }
}
