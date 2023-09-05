﻿using Blackjack_CLI.GameComponents;

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
            Dealer GameDealer = new Dealer();

            foreach (Card card in GameDealer.Deck)
            {
                
                Console.WriteLine(string(card.Value), card.Ace);
            }
        }
    }    
}
