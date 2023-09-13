using Blackjack_CLI.GameComponents;

namespace Blackjack_CLI
{
    internal class Play
    {
        // Game interface
        // Show other players points
        // And the user points and hand
        // Exit game (are you certain?)
        // Save the game (needs access to rwx rights in game directory)

        // Instantiate n players
        // Show interface for n players
        internal static void Game()
        {
            Console.Clear(); // clear previous page, from which user has exited

            // initialise players
            Dealer GameDealer = new();
            Player Player1 = new("Piotr");
            for (int i = 0; i < 3; i++)
            {
                Dealer.DealCard(GameDealer.Deck, Player1.Hand);
            }

            // build interface
            CreateInterface(Player1);
            PrintOptions();

            // at the beginning of each round each player places his bet


        }
        public static void CreateInterface(Player player)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Your hand:");
            foreach (Card card in player.Hand)
            {
                if (card != null)
                {
                    string value = card.Value.ToString();
                    if (card.Ace == true)
                        Console.Write($"{value} Ace, ");
                    else Console.Write($"{value}, ");
                }
            }
            Console.WriteLine("");
        }
        public static void PrintOptions() 
        {
            Console.WriteLine("|=========================|");
            Console.WriteLine("| (H)IT | (S)TAY | (E)XIT |");
            Console.WriteLine("|=========================|");
        }
        public static void MainLoop()
        {
            char userInput = Console.ReadKey(true).KeyChar;
            switch (userInput)
            {
                case 'h':
                    PrePlay.PrePlayPage();
                    break;
                case 's':
                    Credits.CreditsPage();
                    break;
                case 'e':
                    Console.Clear();
                    Console.WriteLine("You have exited the program");
                    return;
                default:
                    Console.WriteLine("Wrong key pressed");
                    MainLoop();
                    break;
            }

        }
    }    
}

/*
 Game Loop
~there should be tutorial if the user plays for the first time~
~but aside from that...~

first thing -- dealing the cards -- happens automatically
the user sees his cards all the time
then the user has options:

 */

// checking if dealers deck is properly initiated
/*foreach (Card card in Player1.Hand)
{
    string value = card.Value.ToString();
    string ace = card.Ace.ToString();
    *//*if (card.Ace == true)*//*
    Console.WriteLine(value, ace);
}*/