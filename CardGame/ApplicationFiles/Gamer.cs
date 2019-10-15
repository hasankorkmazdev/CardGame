using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ApplicationFiles
{
    class Gamer
    {
        string gName;
        int gScore=0;
        public Gamer(string GamerName)
        {
            gName = GamerName;
        }
        public string Name { get => gName; set => gName = value; }
        public int Score { get => gScore; set => gScore = value; }
    }
}
