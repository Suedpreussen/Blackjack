namespace Blackjack_CLI
{
    internal class PrePlay
    {
        internal static void PrePlayPage()
        {
            Console.Clear(); // clear previous page, from which user has exited
            Console.WriteLine("BEGIN  *press b*");
            Console.WriteLine("CHOOSE NUMBER OF PLAYERS  *press n*");
            Console.WriteLine("RETURN  *press r*");
            MainLoop();
        }
        private static void MainLoop()
        {
            char userInput = Console.ReadKey(true).KeyChar;
            switch (userInput)
            {
                case 'b':
                    Play.Game();
                    break;
                case 'n':
                    Console.WriteLine("enter number 1 through 7 and press enter");
                    int numberOfPlayers = Int32.Parse(Console.ReadLine());
                    if (0 < numberOfPlayers & numberOfPlayers < 8)
                    {
                        Console.WriteLine($"You chose a game with {numberOfPlayers} player(s)");
                        MainLoop();
                    }
                    else
                    {
                        Console.WriteLine("You entered invalid number of players");
                        MainLoop();
                    }
                    break;
                case 'r':
                    Program.Main();
                    break;
                default:
                    Console.WriteLine("Wrong key pressed");
                    MainLoop();
                    break;
            }
        }

    }
}
