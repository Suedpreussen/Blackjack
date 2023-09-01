namespace Blackjack_CLI.GameComponents
{
    public class Player
    {
        public int InterfaceLocation; // assigned by instantiation and not mutable
        public string Name; // assigned by instantiation and not mutable
        public int Points = 0; // zero on the onset, mutable
        List<Card> CardsList; // null on the onset; dealer provides player with cards
        Strategy Strategy = new Strategy(); // randomly assigned on the onset
    }
}
