using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchScoreUpdater
{
    class CricketDisplayStatistics : DisplayStatitics
    {
        private Team Team;
        public CricketDisplayStatistics(Team team)
        {
            this.Team = team;
        }
        public override void displayScore()
        {
            
                Console.WriteLine("--------------------Current Stats of " + this.Team.getName() + " -------------------------");
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Score is " + (this.Team.GetStatitics().getStats())["TeamScore"] + " - " + this.Team.GetStatitics().getStats()["Out"]);
                Console.WriteLine((((int)this.Team.GetStatitics().getStats()["Over"]) / 6) + "." + (((int)this.Team.GetStatitics().getStats()["Over"]) % 6) + " overs completed");
                Console.WriteLine("----------------------------------------------------------");
            
        }
    }
}
