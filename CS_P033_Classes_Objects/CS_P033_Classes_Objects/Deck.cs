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
