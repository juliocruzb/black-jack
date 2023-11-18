using System.Globalization;

Console.WriteLine("Welcome, let's play Black Jack!");

var cardDeck = new CardDeck();

var game = new Game(
    player: new Player(Constants.PlayerOneName),
    computer: new Player(Constants.PlayerComputerName),
    dealer: new Dealer(cardDeck)
);

game.Start();

Console.WriteLine("\n========================");
Console.WriteLine("Initial Hands:");

game.Player.PrintHand();
game.Computer.PrintHand();


while (!game.IsGameOver())
{
    Console.WriteLine("\n========================");
    Console.WriteLine("What's your move?:");
    Console.WriteLine("1. Hit");
    Console.WriteLine("2. Stand");

    int choice;
    while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
    {
        Console.WriteLine("Invalid input. Please enter 1 or 2.");
        continue;
    }

    if (choice == 1)
    {
        game.Hit();
    }
    else
    {
        game.Stand();
    }

    Console.WriteLine($"Your card: {game.Player.Hand!.Last()}");
    Console.WriteLine($"Your total points: {game.Player.HandPoints}");
}

Console.WriteLine("\n========================");
Console.WriteLine("Final Hands:");
game.Player.PrintHand();
game.Computer.PrintHand();

Console.WriteLine($"\n\nWinner is: {game.GetWinner().Name}!");
Console.WriteLine($"Game over...");


