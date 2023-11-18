public class Player
{
    private string _name;
    private List<Card>? _hand;    

    public string Name => _name;
    public List<Card>? Hand => _hand;

    public int HandPoints => _hand?.Sum(e => e.Points) ?? 0;

    public Player(string name)
    {
        _name = name;
    }

    public void AddInitialHand(List<Card> initialHand)
    {
        _hand = initialHand;
    }

    public void AddCardToHand(Card card)
    {
        _hand?.Add(card);
    }

    public void PrintHand()
    {
        Console.WriteLine($"\n>>> {Name}:");
        foreach (var card in Hand!)
        {
            Console.WriteLine(card);
        }
        Console.WriteLine($"Points: {HandPoints}");
    }
}