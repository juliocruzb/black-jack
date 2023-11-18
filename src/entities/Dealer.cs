public class Dealer
{
    private CardDeck _cardDeck { get; }

    public Dealer(CardDeck cardDeck)
    {
        _cardDeck = cardDeck;
    }

    public void ShuffleDeck()
    {
        var random = new Random();

        int i = _cardDeck.Cards.Count;

        while (i > 1)
        {
            i--;
            int k = random.Next(i + 1);
            Card value = _cardDeck.Cards[k];
            _cardDeck.Cards[k] = _cardDeck.Cards[i];
            _cardDeck.Cards[i] = value;
        }
    }

    public Card Deal()
    {
        if (_cardDeck.Cards.Count == 0)
        {
            throw new Exception("No more cards!");
        }
        
        Card card = _cardDeck.Cards[0];
        _cardDeck.Cards.RemoveAt(0);

        return card; 
    }
}