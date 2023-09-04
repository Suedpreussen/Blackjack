namespace Blackjack_CLI.GameComponents
{
    public class Dealer 
    {
        internal List<Card> Deck;
        public List<Card> Hand;
        internal Dealer(List<Card> deck, List<Card> hand = null)
        {
            deck = Deck;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 9; j++)
                {
                    Card card = new Card(j);
                    Deck.Add(card);
                }
                for (int k = 0; k < 4; k++)
                {
                    Card card = new Card(10);
                    Deck.Add(card);
                    Card ace = new Card(1, true);
                    Deck.Add(ace);

                }
            }
            Hand = hand;
        }
        public void DealCard()
        {
            Card card = Deck[0];
            card = Deck[1];
            int i = 4;
        }
    }
}
