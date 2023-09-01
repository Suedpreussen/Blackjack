

namespace Blackjack_CLI.GameComponents
{
    public class Card
    {
        public int Value;
        public bool Ace;
        public Card(int value, bool ace=false)
        {
            Value = value;
            Ace = ace;
        }
        public void ChangeAceValue(int input)
        {
            Console.WriteLine("Do you want your ACE to be a 1 or an 11?");
            Switch();
        }

        internal void Switch()
        {
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1)
            {
                Value = 1;
            }
            else if (userInput == 11)
            {
                Value = 11;
            }
            else
            {
                Console.WriteLine("Invalid number");
                Switch();
            }
        }
        
        
    }











        // DEPRECATED
        // I need an easier implementation for now
        /*
        public class Card
        {
            private string Suit;     // spades, clubs, diamonds, hearts
            private string Rank;     // ace, 2-10, jack, queen, king
            private int Value;
            private int deckID;
            public Card(string _Suit, string _Rank, int _Value, int _deckID)
            {
                this.Suit = _Suit;
                this.Rank = _Rank;
                this.Value = _Value;
                this.deckID = _deckID;
            }
        }
        public class PlatonicDeck
        {
            List<Card> cardsList;
            public PlatonicDeck()
            {
                Card aceSpades = new Card("spades", "ace", 11, 0); // value 11 or 1, depends on what is more beneficial for the player
                Card twoSpades = new Card("spades", "two", 2, 1);
                Card threeSpades = new Card("spades", "three", 3, 2);
                Card fourSpades = new Card("spades", "four", 4, 3);
                Card fiveSpades = new Card("spades", "five", 5, 4);
                Card sixSpades = new Card("spades", "six", 6, 5);
                Card sevenSpades = new Card("spades", "seven", 7, 6);
                Card eightSpades = new Card("spades", "eight", 8, 7);
                Card nineSpades = new Card("spades", "nine", 9, 8);
                Card tenSpades = new Card("spades", "ten", 10, 9);
                Card jackSpades = new Card("spades", "jack", 10, 10);
                Card queenSpades = new Card("spades", "queen", 10, 11);

                Card aceClubs = new Card("clubs", "ace", 11, 12); 
                Card twoClubs = new Card("clubs", "two", 2, 13);
                Card threeClubs = new Card("clubs", "three", 3, 14);
                Card fourClubs = new Card("clubs", "four", 4, 15);
                Card fiveClubs = new Card("clubs", "five", 5, 16);
                Card sixClubs = new Card("clubs", "six", 6, 17);
                Card sevenClubs = new Card("clubs", "seven", 7, 18);
                Card eightClubs = new Card("clubs", "eight", 8, 19);
                Card nineClubs = new Card("clubs", "nine", 9, 20);
                Card tenClubs = new Card("clubs", "ten", 10, 21);
                Card jackClubs = new Card("clubs", "jack", 10, 22);
                Card queenClubs = new Card("clubs", "queen", 10, 23);

                Card aceDiamonds = new Card("diamonds", "ace", 11, 24); 
                Card twoDiamonds = new Card("diamonds", "two", 2, 25);
                Card threeDiamonds = new Card("diamonds", "three", 3, 30);
                Card fourDiamonds = new Card("diamonds", "four", 4, 31);
                Card fiveDiamonds = new Card("diamonds", "five", 5, 32);
                Card sixDiamonds = new Card("diamonds", "six", 6, 33);
                Card sevenDiamonds = new Card("diamonds", "seven", 7, 34);
                Card eightDiamonds = new Card("diamonds", "eight", 8, 35);
                Card nineDiamonds = new Card("diamonds", "nine", 9, 36);
                Card tenDiamonds = new Card("diamonds", "ten", 10, 37);
                Card jackDiamonds = new Card("diamonds", "jack", 10, 38);
                Card queenDiamonds = new Card("diamonds", "queen", 10, 39);

                Card aceHearts = new Card("hearts", "ace", 11, 40); 
                Card twoHearts = new Card("hearts", "two", 2, 41);
                Card threeHearts = new Card("hearts", "three", 3, 42);
                Card fourHearts = new Card("hearts", "four", 4, 43);
                Card fiveHearts = new Card("hearts", "five", 5, 44);
                Card sixHearts = new Card("hearts", "six", 6, 45);
                Card sevenHearts = new Card("hearts", "seven", 7, 46);
                Card eightHearts = new Card("hearts", "eight", 8, 47);
                Card nineHearts = new Card("hearts", "nine", 9, 48);
                Card tenHearts = new Card("hearts", "ten", 10, 49);
                Card jackHearts = new Card("hearts", "jack", 10, 50);
                Card queenHearts = new Card("hearts", "queen", 10, 51);
            }
        }
        */
    }
