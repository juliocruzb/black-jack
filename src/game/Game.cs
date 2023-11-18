public class Game
{
    private Player _player;
    private Player _computer;
    private Dealer _dealer;
    private bool _isStand;

    public Player Player => _player;
    public Player Computer => _computer;

    public Dealer Dealer => _dealer;

    public Game(Player player, Player computer, Dealer dealer)
    {      
        _player = player;
        _computer = computer; 
        _dealer = dealer;

        _isStand = false;
    }

    public void Start()
    {
        _dealer.ShuffleDeck();

        // Initial hands
        _player.AddInitialHand(new List<Card>
        {
            _dealer.Deal(),
            _dealer.Deal()
        });

        _computer.AddInitialHand(new List<Card>
        {
            _dealer.Deal(),
            _dealer.Deal()
        });
    }

    /// <summary>
    /// Deals a card to the players
    /// </summary>
    /// <returns>Returns true if the cards were dealt</returns>
    public bool Hit()
    {
        bool dealtCards = false;

        if (!_isStand)
        {
            _player.AddCardToHand(_dealer.Deal()!);
            dealtCards = true;    
        }

        if (_computer.HandPoints < 17)
        {
            _computer.AddCardToHand(_dealer.Deal());
            dealtCards = true;
        }

        return dealtCards;
    }

    public void Stand()
    {
        _isStand = true;
    }

    public bool IsGameOver()
    {
        return _player.HandPoints >= 21 ||
            _computer.HandPoints >= 21 ||
            (_isStand && _computer.HandPoints >= 17);
    }

    public Player GetWinner()
    {
        if ((_player.HandPoints <= 21 && _player.HandPoints > _computer.HandPoints) || _computer.HandPoints > 21)
        {
            return _player;
        }
        else
        {
            return _computer;
        }
    }
}