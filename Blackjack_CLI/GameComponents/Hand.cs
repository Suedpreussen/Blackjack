namespace Blackjack_CLI.GameComponents
{
    public class Hand
    {
        Card card = new Card();
    }
    public class CardOnHand : Card
    {
        // Just add ID so playing with multiple decks is possible
        // but maybe it's possible without tracking the ID of a card?
    }
}
