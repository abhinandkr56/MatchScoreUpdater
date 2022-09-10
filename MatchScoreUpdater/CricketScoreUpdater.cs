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
            CricketMatch match = new CricketMatch(team1, team2);
            match.CreateMatch(team1);
            match.addCommentary("The match between india and pakisthan will start at 7.00am. stay tuned for updates");
            match.addCommentary("Match Started");
            DisplayStatitics displayStatitics = new CricketDisplayStatistics(team1);
            DisplayStatitics displayStatitics2 = new CricketDisplayStatistics(team2);
            
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
                if ((CricketScores)input != CricketScores.MatchEnded)
                {
                    if ((CricketScores)input == CricketScores.FirstBattingCompleted)
                    {
                        match.updateCurrentBatter(team2);
                    }
                    match.UpdateScore<CricketScores>((CricketScores)input, match.getCurrentBatter());
                }

            }

            Console.ReadKey();
        }

       
    }
}
