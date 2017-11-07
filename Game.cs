using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Game
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }


        public Game() { }

        public Game(string team1, string team2, int score1, int score2)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Team1Score = score1;
            this.Team2Score = score2;


        }

        public override string ToString()
        {
            return Team1+" ("+Team1Score+") - "+Team2+" ("+Team2Score+")";
        }


    }
}
