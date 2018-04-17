using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BocceBall.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string Mascot { get; set; }
        public string Color { get; set; }

        // a team has many players
        public ICollection<Player> Player { get; set; } = new HashSet<Player>();

    }
}
