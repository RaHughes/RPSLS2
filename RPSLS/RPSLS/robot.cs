using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class robot : player
    {
        //member variables
        public string name;

        //constructor
        public robot(string name, int score, int currentPick)
        {
            this.name = "Master Mind"; 
            this.score = score;
            this.currentPick = currentPick;
        }
    }
}
