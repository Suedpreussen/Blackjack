namespace Blackjack_CLI.GameComponents
{
    public class Player
    {
        public int interfaceLocation; // assigned by instantiation and not mutable
        public string name; // assigned by instantiation and not mutable
        public int points = 0; // zero on the onset, mutable
        Hand hand = new Hand(null); // null on the onset; dealer provides player with cards
        Strategy strategy = new Strategy(); // randomly assigned on the onset
    }
}
