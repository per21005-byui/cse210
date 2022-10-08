using System;


namespace Unit02.Game
{
    public class Die
    {
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.
        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 
        public int value;
        public int points;

    // 2) Create the class constructor. Use the following method comment.
        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>
        public Die()
        {
            value=0;
            points=0;
        }
    
    // 3) Create the Roll() method. Use the following method comment.
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>
        public void Roll()
        {
            Random rd = new Random();
            int diecast = rd.Next(1,7);
            value = diecast;
            switch(diecast)
            {
                case 1:
                    points=100;
                    break;
                case 5:
                    points = 50;
                    break;
                default:
                    points=0;
                    break;
            }
        }
    }
}