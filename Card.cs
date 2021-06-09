namespace DeckOfCards
{
    public class Card
    {
        public string stringVal { get; set; }
        public string Suit { get; set; }
        public int Val { get; set; }
        public Card(string name,string suit,int val)
        {
            stringVal = name;
            Suit = suit;
            Val = val;
        }
        
    }
}