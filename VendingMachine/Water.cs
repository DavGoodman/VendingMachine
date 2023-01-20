namespace VendingMachine;

public class Water : IDrink
{
    public int price => 20;
    public string name => "Water";
    public void Drink()
    {
        Console.WriteLine($"You have drunk {name}, you feel very refreshed");
    }

}