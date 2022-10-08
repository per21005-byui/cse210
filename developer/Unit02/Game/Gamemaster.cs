using System;

namespace Unit02.Game
{
     public class Gamemaster
    {
        int _points;
        int _prevcard;
        Card _newcard = new Card();
        bool _continue=true;
        public Gamemaster()
        {
            _points = 300;
            _newcard.drawCard();
            _prevcard=_newcard.value;
        }
        public void runGame()
        {
            proposeGame();
            while(_continue)
            {
                evalInputs();
                checkStatus(ref _continue);
            }
        }
        public void proposeGame()
        {
            Console.WriteLine("+--------------------------+");
            Console.WriteLine("| Welcome to the HiLo game |");
            Console.WriteLine("+--------------------------+\n\n");

            Console.WriteLine($"Starting card is: {_prevcard.ToString()}");
        }
        public void evalInputs()
        {
            string bet = hlxLoop("Higher or lower? [h/l]");
            _newcard.drawCard();
            Console.WriteLine($"Next card was: {_newcard.value}");
            if (bet=="x"){
                Console.WriteLine("You decided to quit!");
                Console.WriteLine($"You quit with {_points.ToString()} points to take home.");
                Environment.Exit(0);
            }
            if((bet=="h" && _prevcard<_newcard.value)||(bet=="l" && _prevcard>_newcard.value) )
            {
                _points=_points+100;
            }
            else
            {
                _points=_points-75;
            }
        }
        public void checkStatus(ref bool cont)
        {
            if(_points>0)
            {
                cont = true;
                Console.WriteLine($"You've got {_points} points to play.");
                if (_points<75)
                {
                    Console.WriteLine("You can't afford to loose again.");
                }
                _prevcard=_newcard.value;
                Console.WriteLine($"\n\nThe card is: {_prevcard}.");
            }
            else
            {
                cont = false;
                Console.WriteLine("Sorry mate, you lost all your points!");
            }
        }
        static string hlxLoop(string question)
        {
            string input = "";
            bool valid=false;
            while(!valid)
            {
                Console.WriteLine(question);
                input = Console.ReadLine().Trim().ToLower();
                if("hlx".Contains(input))
                {
                    valid=true;
                }
                else
                {
                    Console.WriteLine("Write a valid option!");
                }
            }
            return input;
        }
    }
}