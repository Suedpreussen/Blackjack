namespace Blackjack_CLI
{
    internal class PrePlay
    {
        internal static void PrePlayPage()
        {
            Console.Clear(); // clear previous page, from which user has exited
            Console.WriteLine("STANDARD RULES  *press s*");
            Console.WriteLine("ANOTHER RULE  *press a*");
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
                case 'c':
                    //Play(); future method
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
