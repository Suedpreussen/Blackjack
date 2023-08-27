using System;
namespace Blackjack_CLI
{
    internal class Credits
    {
        internal static void CreditsPage()
        {
            Console.Clear();
            Console.WriteLine("This app was made by MeSoftworks, 2023");
            Console.WriteLine("RETURN  *press r*");
            Switch();
        }
        private static void Switch()
        {
            char userInput = Console.ReadKey(true).KeyChar;
            switch (userInput)
            {
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
