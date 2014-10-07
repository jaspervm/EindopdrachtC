using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerConsole
{
    public enum soort { ruiten, klaveren, harten, schoppen }

    public enum waarde { twee = 2, drie = 3, vier = 4, vijf = 5, zes = 6, zeven = 7, acht = 8, negen = 9, tien = 10, boer = 11, vrouw = 12, heer = 13, aas = 14 }
    class Card 
    {
        private soort s;
        private waarde w;

        public Card(soort s, waarde w)
        {
            this.s = s;
            this.w = w;

        }

        public waarde getWaarde()
        {

            return w;

        }

        public soort getSoort()
        {

            return s;

        }

       
 
    }

    class CardComparer : IComparer<waarde>
    {
        public int Compare(waarde x, waarde y)
        {
            int xIndex = (int)x;
            int yIndex = (int)y;

            return xIndex.CompareTo(yIndex);
        }
    }
}
