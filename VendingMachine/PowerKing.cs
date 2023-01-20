using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class PowerKing : IDrink
    {
        public int price => 30;
        public string name => "Power King";

        public void Drink()
        {
            Console.WriteLine($"You have drunk {name}, you feel like a king !");
        }

    }

}
