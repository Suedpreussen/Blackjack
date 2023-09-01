namespace Blackjack_CLI.GameComponents
{
    public class Card
    {
        private string Suit;     // spades, clubs, diamonds, hearts
        private string Rank;     // ace, 2-10, jack, queen, king
        private int Value;
        public Card(string _Suit, string _Rank, int _Value)
        {
            this.Suit = _Suit;
            this.Rank = _Rank;
            this.Value = _Value;
        }
    }
    public class PlatonicDeck
    {
        Card
        public PlatonicDeck()
        {
            Card aceSpades = new Card("spades", "ace", 11); // value 11 or 1, depends on what is more beneficial for the player
            Card oneSpades = new Card("spades", "one", 1);
            Card twoSpades = new Card("spades", "two", 2);
            Card threeSpades = new Card("spades", "three", 3);
            Card fourSpades = new Card("spades", "four", 4);
            Card fiveSpades = new Card("spades", "five", 5);
            Card sixSpades = new Card("spades", "six", 6);
            Card sevenSpades = new Card("spades", "seven", 7);
            Card eightSpades = new Card("spades", "eight", 8);
            Card nineSpades = new Card("spades", "nine", 9);
            Card tenSpades = new Card("spades", "ten", 10);
            Card jackSpades = new Card("spades", "jack", 10);
            Card queenSpades = new Card("spades", "queen", 10);

            Card aceClubs = new Card("clubs", "ace", 11); 
            Card oneClubs = new Card("clubs", "one", 1);
            Card twoClubs = new Card("clubs", "two", 2);
            Card threeClubs = new Card("clubs", "three", 3);
            Card fourClubs = new Card("clubs", "four", 4);
            Card fiveClubs = new Card("clubs", "five", 5);
            Card sixClubs = new Card("clubs", "six", 6);
            Card sevenClubs = new Card("clubs", "seven", 7);
            Card eightClubs = new Card("clubs", "eight", 8);
            Card nineClubs = new Card("clubs", "nine", 9);
            Card tenClubs = new Card("clubs", "ten", 10);
            Card jackClubs = new Card("clubs", "jack", 10);
            Card queenClubs = new Card("clubs", "queen", 10);

            Card aceDiamonds = new Card("diamonds", "ace", 11); 
            Card oneDiamonds = new Card("diamonds", "one", 1);
            Card twoDiamonds = new Card("diamonds", "two", 2);
            Card threeDiamonds = new Card("diamonds", "three", 3);
            Card fourDiamonds = new Card("diamonds", "four", 4);
            Card fiveDiamonds = new Card("diamonds", "five", 5);
            Card sixDiamonds = new Card("diamonds", "six", 6);
            Card sevenDiamonds = new Card("diamonds", "seven", 7);
            Card eightDiamonds = new Card("diamonds", "eight", 8);
            Card nineDiamonds = new Card("diamonds", "nine", 9);
            Card tenDiamonds = new Card("diamonds", "ten", 10);
            Card jackDiamonds = new Card("diamonds", "jack", 10);
            Card queenDiamonds = new Card("diamonds", "queen", 10);

            Card aceHearts = new Card("hearts", "ace", 11); 
            Card oneHearts = new Card("hearts", "one", 1);
            Card twoHearts = new Card("hearts", "two", 2);
            Card threeHearts = new Card("hearts", "three", 3);
            Card fourHearts = new Card("hearts", "four", 4);
            Card fiveHearts = new Card("hearts", "five", 5);
            Card sixHearts = new Card("hearts", "six", 6);
            Card sevenHearts = new Card("hearts", "seven", 7);
            Card eightHearts = new Card("hearts", "eight", 8);
            Card nineHearts = new Card("hearts", "nine", 9);
            Card tenHearts = new Card("hearts", "ten", 10);
            Card jackHearts = new Card("hearts", "jack", 10);
            Card queenHearts = new Card("hearts", "queen", 10);
        }
    }
}
