public class Card
{
    public string Suit;

    public string Rank;

    public int Points;

    public Card(string rank, int value, string suit)
    {
        Rank = rank;
        Points = value;
        Suit = suit;
    }

    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}