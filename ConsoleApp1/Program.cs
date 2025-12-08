namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var MyDeck = new DeckOfCards();

            var myCard = MyDeck.DealCard();

            Console.WriteLine($"My card is {myCard.Rank}, of {myCard.Suit}");

        }
    }
}