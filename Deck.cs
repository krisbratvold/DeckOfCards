using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> cards { get; set; }
        public Deck()
        {
            cards = new List<Card>();
            string[] stringVal ={"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] Suit = {"Clubs","Spades","Hearts","Diamonds"};
            int[] Val = {1,2,3,4,5,6,7,8,9,10,11,12,13};
            for (int i = 0; i < Suit.Length; i++)
            {
                for (int j = 0; j < stringVal.Length; j++)
                {
                    cards.Add(new Card(stringVal[j],Suit[i],Val[j]));
                }
            }
        }
        public Card Deal(int times, Player player)
        {
            for (int i = 0; i < times; i++)
            {
            Console.WriteLine(cards[0].stringVal +" of "+ cards[0].Suit);
            player.Hand.Add(cards[0]);
            cards.Remove(cards[0]);
            }
            return cards[0];
        }
        public void Reset()
        {
            cards.Clear();
            string[] stringVal ={"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            string[] Suit = {"Clubs","Spades","Hearts","Diamonds"};
            int[] Val = {1,2,3,4,5,6,7,8,9,10,11,12,13};
            for (int i = 0; i < Suit.Length; i++)
            {
                for (int j = 0; j < stringVal.Length; j++)
                {
                    cards.Add(new Card(stringVal[j],Suit[i],Val[j]));
                }
            }
        }
        public void Shuffle()
        {
            Random rand = new Random();
            List<Card> Shuffled = new List<Card>();
            while (cards.Count > 0)
            {
                Card randomCard = cards[rand.Next(0,cards.Count)];
                Shuffled.Add(randomCard);
                cards.Remove(randomCard);
            }
            cards = Shuffled;
        }
    }
}