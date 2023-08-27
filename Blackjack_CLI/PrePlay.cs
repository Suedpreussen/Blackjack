namespace Blackjack_CLI
{
    internal class PrePlay
    {
        internal static void PrePlayPage()
        {
            Console.Clear(); // clear previous page, from which user has exited
            Console.WriteLine("PLAY  *press p*");
            Console.WriteLine("CHOOSE NUMBER OF PLAYERS  *press n*");
            Console.WriteLine("RETURN  *press r*");
            Switch();
        }
        private static void Switch()
        {
            char userInput = Console.ReadKey(true).KeyChar;
            switch (userInput)
            {
                case 'p':
                    //Play(); future method
                    break;
                case 'n':
                    Console.WriteLine("enter number 1 through 7 and press enter");
                    int numberOfPlayers = Int32.Parse(Console.ReadLine());
                    if (0 < numberOfPlayers & numberOfPlayers < 8)
                    {
                        Console.WriteLine($"You chose a game with {numberOfPlayers} player(s)");
                        Switch();
                    }
                    else
                    {
                        Console.WriteLine("You entered invalid number of players");
                        Switch();
                    }
                    break;
                case 'r':
                    Program.Main();
                    break;
                default:
                    Console.WriteLine("Wrong key pressed");
                    Switch();
                    break;
            }
        }

    }
}
