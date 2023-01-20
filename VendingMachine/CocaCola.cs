namespace VendingMachine;

public class CocaCola : IDrink
{
    public int price => 25;
    public string name => "CocaCola";
    public void Drink()
    {
        Console.WriteLine($"You have drunk {name}, you only feel more thirsty now...");
    }
}