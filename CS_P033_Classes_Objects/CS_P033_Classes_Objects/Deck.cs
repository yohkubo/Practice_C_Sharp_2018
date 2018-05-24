using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P033_Classes_Objects
{
    class Deck
    {
        public Deck()
        {
            //Cards = new List<Card>();

            List<string> Suits = new List<string>() { "Clubs", "Spades", "Hearts", "Diamonds" };
            List<string> Faces = new List<string>()
            { "Two","Three","Four","Five","Six","Seven",
                "Eight","Nine","Ten","Jack","Queen","King","Ace"};
            
            foreach(string suit in Suits)
            {
                foreach (string face in Faces)
                {
                    Card cardOne = new Card();
                    cardOne.Suit = suit;
                    cardOne.Face = face;
                    Cards.Add(cardOne);
                }
            }
        }
            
        public List<Card> Cards = new List<Card>();
    }
}
