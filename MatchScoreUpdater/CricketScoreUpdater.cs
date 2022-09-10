using System;
using System.Collections;

namespace MatchScoreUpdater
{
    class CricketScoreUpdater
    {
        static void Main(string[] args)
        {
            Statitics Teamstatitics1 = new Statitics();
            Statitics Teamstatitics2 = new Statitics();
            Team team1 = new Team("India",Teamstatitics1);
            Team team2 = new Team("Pakisthan",Teamstatitics2);
            Match match = new Match(team1, team2);
            match.CreateMatch(team1.getName());
            match.addCommentary("The match between india and pakisthan will start at 7.00am. stay tuned for updates");
            match.addCommentary("Match Started");
            DisplayStatitics displayStatitics = new DisplayStatitics(team1);
            DisplayStatitics displayStatitics2 = new DisplayStatitics(team2);
            
            while (!match.IsMatchEnded())
            {
                displayStatitics.displayScore();
                displayStatitics2.displayScore();
                Console.WriteLine("Enter what happened(enter serialnumber)");
                int serialNumber = 1;
                foreach(var item in Enum.GetValues(typeof(CricketScores))){
                    Console.WriteLine(serialNumber + "."+item);
                    serialNumber++;
                }
                var input = int.Parse(Console.ReadLine());
                match.UpdateScore((CricketScores)input,team1);
            }

            Console.ReadKey();
        }

       
    }
}
