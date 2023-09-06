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
        internal static void GameLoop()
        {
            Console.Clear(); // clear previous page, from which user has exited

            Dealer GameDealer = new Dealer();
            Player Player1 = new Player("Piotr");
            Dealer.DealCard(GameDealer.Deck, Player1.Hand);


            // checking if dealers deck is properly initiated
            foreach (Card card in Player1.Hand)
            {
                string value = card.Value.ToString();
                string ace = card.Ace.ToString();
                /*if (card.Ace == true)*/
                    Console.WriteLine(value, ace);
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