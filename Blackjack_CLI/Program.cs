using Blackjack_CLI.GameComponents;

namespace Blackjack_CLI
{
    internal class Program
    {
        internal static void Main()
        {
            Console.Clear(); // clear previous page, from which user has exited            
            Console.WriteLine("PLAY  *press p*");
            Console.WriteLine("CREDITS  *press c*");
            Console.WriteLine("END  *press e*");
            Switch();  
        }
        private static void Switch()
        {
            char userInput = Console.ReadKey(true).KeyChar;
            switch (userInput)
            {
                case 'p':
                    PrePlay.PrePlayPage();
                    break;
                case 'c':
                    Credits.CreditsPage();
                    break;
                case 'e':
                    Console.Clear();
                    Console.WriteLine("You have exited the program");
                    return;
                default:
                    Console.WriteLine("Wrong key pressed");
                    Switch();
                    break;
            }
        }
    }
}

/*
BLACKJACK

1 to 8 decks, each consisting of 52 cards:
4 courts, in each we have got: an ace, cards 2 through 10, jack, queen and king

2 through 10 count at face value, i.e. a 2 counts as two, a 9 counts as nine.
Face cards (J,Q,K) count as 10.
Ace can count as a 1 or an 11 depending on which value helps the hand the most.

5 to 9 players play against the dealer

The goal is to have the highest value but not exceeding 21
*/

/*
 * STRUCTURE OF THE APP
 * 
 * Main Page:
 *  <Buttons>
 *  Play --> takes you to another page PrePlayPage
 *  Credits --> takes you to another page CreditsPage
 *  Quit --> ends the loop
 *  
 * PrePlayPage:
 *  <Buttons>
 *  Begin Now! --> takes you to another page PlayPage
 *  Some settings
 *  
 * CreditsPage:
 *  Just some text
 */