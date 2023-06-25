using PlayerClasses;

Random random = new Random();

double odds = 0.75;

Player player = new Player("Tony", 100);

    Console.WriteLine("Welcome to NeverWin Casino, where the odds are stacked against you!");
    Console.WriteLine();


while (player.Cash > 0)
{

    player.WriteMyInfo();
    Console.Write($"How much money would you like to bet {player.Name}? ");
    string howMuch = Console.ReadLine();
    Console.WriteLine();

    if (int.TryParse(howMuch, out int amount))
    {
        int pot = player.GiveCash(amount) * 2;

        double number = random.NextDouble();

        if(number > odds)
        {
            player.ReceiveCash(pot);
            Console.WriteLine("Hey, you won: " + pot + " dollars! Congratulations!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("You lost this round, better luck next time!");
            Console.WriteLine();
        }
    }
}

Console.WriteLine("Ohhh, I'm sorry, but you ran out of money.\n\nWe also have a pawn shop if that might help you!");