using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchScoreUpdater
{
    abstract class Match
    {
        private Team team1;
        private Team team2;
        private bool MatchEnded;
        public Match(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }
        public abstract void CreateMatch(Team matchStarter);
       
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
        public abstract void UpdateScore<T>(T key, Team team);
       
    }
}
