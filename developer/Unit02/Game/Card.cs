using System;

namespace Unit02.Game
{
     public class Card
    {
        public int value;
        public Card()
        {
            value = 0;

        }
        public void drawCard()
        {
            Random rd = new Random();
            int drawnCard = rd.Next(1,15);
            value = drawnCard;
            //return value;
        }
    }
}