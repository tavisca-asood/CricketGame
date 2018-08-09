using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Cricket
    {
        public bool Out { get; set; }
        public int PlayerScore { get; set; }
        public Cricket()
        {
            PlayerScore = 0;
        }

        public void Score(int runs)
        {
            if (Out == true)
                return;
            if(runs>0&&runs<7)
            PlayerScore += runs;
            else
            PlayerScore = 0;
        }

        public int IsScoreGreater(Cricket player2)
        {
            if (this.PlayerScore > player2.PlayerScore)
                return 1;
            if (this.PlayerScore == player2.PlayerScore)
                return 0;
            return -1;
        }

    }
}
