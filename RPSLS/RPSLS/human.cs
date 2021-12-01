using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class human : player
    {
        //member variables
        public string name;

        //constructor
        public human(string name, int score, int currentPick)
        {
            this.name = name;
            this.score = score;
            this.currentPick = currentPick;
        }

        //actions
        public void getName()
        {
            Console.WriteLine("Please input your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Thanks You" + playerName);
            name = playerName;
        }
    }
}
