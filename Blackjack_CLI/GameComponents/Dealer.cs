using System.ComponentModel.DataAnnotations;

namespace Blackjack_CLI.GameComponents
{
    public class Dealer 
    {
        public List<Card> Deck = new List<Card>();
        public List<Card> Hand = new List<Card>();
        public Dealer()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Card card = new Card(j);
                    Deck.Add(card);
                }
                for (int k = 0; k < 4; k++)
                {
                    Card card = new Card(10);
                    Deck.Add(card);
                }
                Card ace = new Card(1, true);
                Deck.Add(ace);
            }
        }
        public static void DealCard(List<Card> deck, List<Card> hand)
        {
            Random random = new Random();
            int RandomIndex = random.Next(0, deck.Count);
            deck.Remove(deck[RandomIndex]);
            hand.Add(deck[RandomIndex]);
        }
    }
}
