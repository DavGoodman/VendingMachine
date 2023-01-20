using System.Threading.Channels;
using static System.Console;
namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var drinkList = new DrinkSet();

            VendingMachine vendingMachine = new VendingMachine(drinkList.RandomDrinks(10));
            IDrink drink;

            while (true)
            {
                Console.WriteLine("Hva ønsker du å kjøpe?\n" +
                                  "F: Fanta\n" +
                                  "C: Coke\n" +
                                  "P: PowerKing\n" +
                                  "W: Water\n" +
                                  "1: Insert 1kr\n" +
                                  "5: Insert 5kr\n" +
                                  "10: Insert 10kr\n" +
                                  "20: Insert 20kr\n" +
                                  "R: Refund money\n" +
                                  "X: Exit");          
                
                string command = Console.ReadLine();

                if(command == "F") drink = vendingMachine.BuyDrink("Fanta");
                else if(command == "C") drink = vendingMachine.BuyDrink("CocaCola");
                else if(command == "P") drink = vendingMachine.BuyDrink("PowerKing");
                else if(command == "W") drink = vendingMachine.BuyDrink("Water");
                else if(command == "1") vendingMachine.InsertCoin(1);
                else if(command == "5") vendingMachine.InsertCoin(5);
                else if(command == "10") vendingMachine.InsertCoin(10);
                else if(command == "20") vendingMachine.InsertCoin(20);
                else if (command == "R")
                {
                    int refund = vendingMachine.Refund();
                    Console.WriteLine($"You have been refunded {refund}kr");
                }
                else if(command == "X") break;

                //if (drink != null)
                //{
                //    drink.Drink();
                //}

            }
        }
    }
}

/*
 
 string day = "Monday";

switch (day)
{
    case "Monday":
        Console.WriteLine("It's Monday!");
        break;
    case "Tuesday":
        Console.WriteLine("It's Tuesday!");
        break;
    case "Wednesday":
        Console.WriteLine("It's Wednesday!");
        break;
    default:
        Console.WriteLine("It's some other day.");
        break;
}

 
 
 
 */
