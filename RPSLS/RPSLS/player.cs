using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class player
    {
        //member variables
        public int score;
        public int currentPick;

        //constructor
        public player()
        {
  
        }

        //actions
        public void pickGesture(int pick)
        {
            currentPick = pick;
        }
    }
}
