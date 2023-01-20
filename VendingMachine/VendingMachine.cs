using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class VendingMachine
    {
        public List<IDrink> _inventory;
        public int InsertedMoney;

        public VendingMachine(List<IDrink> inventory)
        {
            _inventory = new List<IDrink>();
            foreach (var drink in inventory)
            {
                _inventory.Add(drink);
            }
        }

        public void InsertCoin(int coin)
        {
            InsertedMoney += coin;
        }

        public IDrink BuyDrink(string drinkName)
        {
            foreach (var drink in _inventory)
            {
                if (drink.name == drinkName)
                {
                    if (InsertedMoney >= drink.price)
                    {
                        InsertedMoney -= drink.price;
                        return drink;
                    }
                }
            }
            Console.WriteLine("Drink not in stock");
            return null;
        }   

        public int Refund()
        {
            int refund = InsertedMoney;
            InsertedMoney = 0;
            return refund;
        }
        
    }
}
