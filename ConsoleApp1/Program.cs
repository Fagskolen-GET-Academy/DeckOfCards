namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDeck = new DeckOfCards();

            var myCard = myDeck.DealCard();

            Console.WriteLine($"My card is {myCard.Rank} of {myCard.Suit}");
        }
    }
}