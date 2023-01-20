namespace VendingMachine;

public class Fanta : IDrink
{
    public int price => 27;
    public string name => "Fanta";

    public void Drink()
    {
        Console.WriteLine($"You have drunk {name}, you feel lemony");
    }

    public void Shake()
    {
        Console.WriteLine("Something");
    }

}