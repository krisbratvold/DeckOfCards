using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }
        public Card Draw(Deck deck, int times, Player player)
        {
            Card card = deck.Deal(times,player);
            return card;
        }
        public Card Discard(int indx)
        {
            if (Hand.Count < indx)
            {
                return null;
            }
            else{
                Card removed = Hand[indx];
                Hand.Remove(removed);
                Console.WriteLine(removed.stringVal + " of " + removed.Suit + " was removed.");
                return removed;
            }
        }
    }
}