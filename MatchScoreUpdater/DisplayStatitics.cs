using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchScoreUpdater
{
    class DisplayStatitics
    {
        private Team Team;
        public DisplayStatitics(Team team)
        {
            this.Team = team;
        }
        public void displayScore()
        {
            Console.WriteLine("--------------------Current Stats of "+this.Team.getName()+ " -------------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Score is "+(this.Team.GetStatitics().getStats())["TeamScore"] + " - " + this.Team.GetStatitics().getStats()["Out"]);
            Console.WriteLine(String.Format("{0:0.0}", (((double)this.Team.GetStatitics().getStats()["Over"] / 6 + (double)this.Team.GetStatitics().getStats()["Over"] % 6) / 10)) + " balls completed");
            Console.WriteLine("----------------------------------------------------------");

        }
    }
}
