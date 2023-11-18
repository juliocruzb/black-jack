public class CardDeck
{
    private readonly Dictionary<string, int> _ranks;
    private readonly List<string> _suits;

    public List<Card> Cards;

    public CardDeck()
    {
        Cards = new List<Card>();

        _ranks = new Dictionary<string, int>()
        {
            {"Two", 2},
            {"Three", 3},
            {"Four", 4},
            {"Five", 5},
            {"Six", 6},
            {"Seven", 7},
            {"Eight", 8},
            {"Nine", 9},
            {"Ten", 10},
            {"Jack", 10},
            {"Queen", 10},
            {"King", 10},
            {"Ace", 11}
        };

        _suits = new List<string>(){
            "Hearts",
            "Diamonds",
            "Spades",
            "Clubs"
        };

        LoadCards();
    }

    private void LoadCards()
    {
        foreach (var rank in _ranks)
        {
            foreach (var suit in _suits)
            {
                Cards.Add(new Card(rank.Key, rank.Value, suit));
            }
        }
    }
}