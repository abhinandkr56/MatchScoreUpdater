using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchScoreUpdater
{
    class Match
    {
        private Team team1;
        private Team team2;
        private bool MatchEnded;

        public Match(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }

        public void CreateMatch(string matchStarter)
        {
            Console.WriteLine("The match between "+team1.getName()+" and "+team2.getName()+" started. "+matchStarter+" won the toss wil start the play first.");

            team1.GetStatitics().addStats("TeamScore", 0);
            team1.GetStatitics().addStats("Out", 0);
            team1.GetStatitics().addStats("Over", 0.0);
            team1.GetStatitics().addStats("TotalOver", 20.0);
            team2.GetStatitics().addStats("TeamScore", 0);
            team2.GetStatitics().addStats("Out", 0);
            team2.GetStatitics().addStats("Over", 0.0);
            team2.GetStatitics().addStats("TotalOver", 20.0);
        }
        public void addCommentary(string commentary)
        {
            Console.WriteLine(commentary);
        }
        public void endMatch()
        {
            this.MatchEnded = true;
        }
        public bool IsMatchEnded()
        {
            return this.MatchEnded;
        }
        public void UpdateScore(CricketScores key,Team team)
        {
            double currentScore= (double)team.GetStatitics().getStats()["TeamScore"];
            double currentOver= (double)team.GetStatitics().getStats()["Over"];
            double currentOut = (double)team.GetStatitics().getStats()["Out"];
            switch (key)
            {
                case CricketScores.Single:
                    team.GetStatitics().getStats()["TeamScore"] = (currentScore+1);
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
