using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_P033_Classes_Objects
{
    public class Deck
    {
        public Deck()
        {
            //Cards = new List<Card>();

            for (int i = 0; i<13; i++)
            {
                for(int j = 0; j<4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

            
            //    List<Suit> Suits = new List<Suit>()
            //{ Suit.Clubs, Suit.Diamonds, Suit.Hearts, Suit.Spades };

            //List<string> Faces = new List<string>()
            //{ "Two","Three","Four","Five","Six","Seven",
            //    "Eight","Nine","Ten","Jack","Queen","King","Ace"};
            
            //foreach(Suit suit in Suits)
            //{
            //    foreach (string face in Faces)
            //    {
            //        Card cardOne = new Card();
            //        cardOne.Suit = suit;
            //        cardOne.Face = face;
            //        Cards.Add(cardOne);
            //    }
            //}
        }
            
        public List<Card> Cards = new List<Card>();

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int ranNum = random.Next(0, Cards.Count);
                    TempList.Add(Cards[ranNum]);
                    Cards.RemoveAt(ranNum);
                }
                this.Cards = TempList;
            }
        }
    }
}
