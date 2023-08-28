namespace Blackjack_CLI.GameComponents
{
    public struct Card
    {
        public int DeckId;
        public string Suit;     // spades, clubs, diamonds, hearts
        public string Rank;     // ace, 2-10, jack, queen, king
        public int Value;
    }
}
