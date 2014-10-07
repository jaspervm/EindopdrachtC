using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerConsole
{
    class Program
    {
        public Card[] hand = new Card[5];
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            List<Card> deck = new Deck().getDeck();

            hand[0] = deck[1];
            hand[1] = deck[12];
            hand[2] = deck[15];
            hand[3] = deck[27];
            hand[4] = deck[35];

            Array.Sort(hand, Compare);

            foreach (Card card in hand)
            {
                Console.WriteLine(card.getWaarde().ToString());
                Console.WriteLine((int)card.getWaarde());
            }

            Console.ReadLine();

        }

        public static int Compare(Card x, Card y)
        {
            int xIndex = (int)x.getWaarde();
            int yIndex = (int)y.getWaarde(); ;

            return xIndex.CompareTo(yIndex);
        }

        public int calculateRank()
        {

            foreach (Card card in hand)
            {
                if (card.getSoort() == hand[0].getSoort())
                {

                }
                else
                {

                }
            }



            return 1;
        }
    }
}
