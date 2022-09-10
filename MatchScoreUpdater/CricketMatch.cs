using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchScoreUpdater
{
    class CricketMatch:Match
    {
        private Team team1;
        private Team team2;
        private Team currentBatter;
        public CricketMatch(Team team1, Team team2):base(team1,team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }

        public override void CreateMatch(Team matchStarter)
        {
            currentBatter = matchStarter;
            Console.WriteLine("The match between " + team1.getName() + " and " + team2.getName() + " started. " + matchStarter.getName() + " won the toss wil start the play first.");

            team1.GetStatitics().addStats("TeamScore", 0);
            team1.GetStatitics().addStats("Out", 0);
            team1.GetStatitics().addStats("Over", 0);
            team1.GetStatitics().addStats("TotalOver", 20);
            team2.GetStatitics().addStats("TeamScore", 0);
            team2.GetStatitics().addStats("Out", 0);
            team2.GetStatitics().addStats("Over", 0);
            team2.GetStatitics().addStats("TotalOver", 20);
        }
        public void updateCurrentBatter(Team team)
        {
            this.currentBatter = team;
        }
        public Team getCurrentBatter()
        {
            return this.currentBatter;
        }

        public override void UpdateScore<T>(T key, Team team)
        {
            int currentScore = (int)team.GetStatitics().getStats()["TeamScore"];
            int currentOver = (int)team.GetStatitics().getStats()["Over"];
            int currentOut = (int)team.GetStatitics().getStats()["Out"];
            switch (key)
            {
                case CricketScores.Single:
                    team.GetStatitics().getStats()["TeamScore"] = (currentScore + 1);
                    team.GetStatitics().getStats()["Over"] = (currentOver + 1);
                    break;
                case CricketScores.Double:
                    team.GetStatitics().getStats()["TeamScore"] = (currentScore + 2);
                    team.GetStatitics().getStats()["Over"] = (currentOver + 1);
                    break;
                case CricketScores.Triple:
                    team.GetStatitics().getStats()["TeamScore"] = (currentScore + 3);
                    team.GetStatitics().getStats()["Over"] = (currentOver + 1);
                    break;
                case CricketScores.Four:
                    team.GetStatitics().getStats()["TeamScore"] = (currentScore + 4);
                    team.GetStatitics().getStats()["Over"] = (currentOver + 1);
                    break;
                case CricketScores.Six:
                    team.GetStatitics().getStats()["TeamScore"] = (currentScore + 6);
                    team.GetStatitics().getStats()["Over"] = (currentOver + 1);
                    break;
                case CricketScores.LBWOut:
                    team.GetStatitics().getStats()["Out"] = (currentOut + 1);
                    team.GetStatitics().getStats()["Over"] = (currentOver + .1);
                    break;
                case CricketScores.StumpedOut:
                    team.GetStatitics().getStats()["Out"] = (currentOut + 1);
                    team.GetStatitics().getStats()["Over"] = (currentOver + 1);
                    break;
                case CricketScores.CatchOut:
                    team.GetStatitics().getStats()["Out"] = (currentOut + 1);
                    team.GetStatitics().getStats()["Over"] = (currentOver + 1);
                    break;
                case CricketScores.Bowled:
                    team.GetStatitics().getStats()["Out"] = (currentOut + 1);
                    team.GetStatitics().getStats()["Over"] = (currentOver + 1);
                    break;
                case CricketScores.RunOut:
                    team.GetStatitics().getStats()["Out"] = (currentOut + 1);
                    team.GetStatitics().getStats()["Over"] = (currentOver + 1);
                    break;
            }
        }
    }
}
