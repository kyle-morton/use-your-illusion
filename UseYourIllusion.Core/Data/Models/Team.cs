using System;
using System.Collections.Generic;
using System.Text;

namespace UseYourIllusion.Core.Data.Models
{
    public class Team : Base
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection<Player> Players { get; set; }
        public Manager Manager;
    }
}
