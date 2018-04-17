using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocceBall.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public int? Number { get; set; }
        public string ThrowingArm { get; set; }

        //// ! public int FKTeamId { get; set; } => using EF to generate the FK
        public int? TeamID { get; set; }
        public Team Team { get; set; }

    }
}
