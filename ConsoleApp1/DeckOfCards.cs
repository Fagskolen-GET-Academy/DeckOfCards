namespace ConsoleApp1
{
    internal class DeckOfCards
    {
        public readonly List<Card> Deck = new();

        public DeckOfCards()
        {
            BuildCards();
        }

        private void BuildCards()
        {
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 0; rankVal < 13; rankVal++)
                {
                    Deck.Add(new Card((Rank)rankVal, (Suit)suitVal));
                }
            }
        }

        public Card DealCard()
        {
            Shuffle();
            var topCard = Deck[0];
            return topCard;
        }

        public void Shuffle()
        {
            var rng = new Random();

            for (int i = Deck.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);

                (Deck[i], Deck[j]) = (Deck[j], Deck[i]);
            }
        }
    }
}
