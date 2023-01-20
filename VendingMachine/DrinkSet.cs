using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class DrinkSet
    {
        private List<IDrink> _drinks;
        public DrinkSet()
        {
            _drinks = new List<IDrink>();
            _drinks.Add(new Fanta());
            _drinks.Add(new CocaCola());
            _drinks.Add(new PowerKing());
            _drinks.Add(new Water());
        }

        public IDrink RandomDrink()
        {
            var rand = new Random();
            return _drinks[rand.Next(0, 4)];
        }

        public List<IDrink> RandomDrinks(int count)
        {
            var outputList = new List<IDrink>();
            for (int i = 0; i < count; i++)
            {
                outputList.Add(RandomDrink());
            }
            return outputList;
        }

       
    }
}
