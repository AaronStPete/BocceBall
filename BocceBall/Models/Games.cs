using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocceBall.Models
{
    public class Games
    {
        public int ID { get; set; }

        public int? HomeTeamID { get; set; }
        public Team HomeTeam { get; set; }

        public int AwayTeamID { get; set; }
        public Team AwayTeam { get; set; }

        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }


    }


}
