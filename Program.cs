using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Player kris = new Player("Kris");
            Player bill = new Player("bill");
            Deck deck1 =new Deck();
            deck1.Shuffle();
            kris.Draw(deck1,7,kris);
            Console.WriteLine("Bill");
            deck1.Deal(7,bill);
            kris.Discard(3);
            Console.WriteLine("done");
        }
    }
}
